using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Server.Data;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services
{
    public class ServicoDeApostas : Euromilhoes.EuromilhoesBase
    {
        private readonly ILogger<ServicoDeApostas> _logger;
        private readonly ServerContext _dbContext;

        public ServicoDeApostas(ILogger<ServicoDeApostas> logger, ServerContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }


        public override async Task<ResultadoPedido> RegistarAposta(PedidoAposta request, ServerCallContext context)
        {
            var user = _dbContext.Utilizadors.FirstOrDefault(x => x.Nome == request.Aposta.Nome);
            if (user == null)
            {  
                user = new Utilizador { Nome = request.Aposta.Nome };
                _dbContext.Add(user);
            }
            Apostum aposta = new Apostum
            {
                Chave = request.Aposta.Chave,
                DataRegisto = request.Aposta.Data,
                Arquivada = false,
                Utilizador = user
            };
            _dbContext.Add(aposta);
            try
            {
                await _dbContext.SaveChangesAsync();
                return await Task.FromResult(new ResultadoPedido { Resultado = true });
            }
            catch (DbUpdateException)
            {
                return await Task.FromResult(new ResultadoPedido { Resultado = false });
            }
        }

        public override async Task<ResultadoPedido> ArquivarApostas(PedidoArquivarApostas request, ServerCallContext context)
        {
            var apostasCorrentes = _dbContext.Aposta.Where(x => x.Arquivada == false).ToList();
            foreach (var x in apostasCorrentes)
            {
                x.Arquivada = true;
            }

            try
            {
                await _dbContext.SaveChangesAsync();
                return await Task.FromResult(new ResultadoPedido { Resultado = true });
            }
            catch (DbUpdateException)
            {
                return await Task.FromResult(new ResultadoPedido { Resultado = false });
            }
        }

        public override async Task<ListaUtilizadores> ListarUtilizadores(PedidoListarUtilizadores request, ServerCallContext context)
        {
            ListaUtilizadores listaUtilizadores = new ListaUtilizadores();
            var utilizadores = await _dbContext.Aposta.Include(x => x.Utilizador)
                .Where(x => x.Arquivada == false)
                .Select(a => a.Utilizador.Nome).Distinct().ToListAsync();

            foreach (var x in utilizadores)
            {
                listaUtilizadores.Utilizador.Add(x);
            }
            return await Task.FromResult(listaUtilizadores);
        }



        public override async Task<ListaDeApostas> ListarApostas(PedidoListarApostas request, ServerCallContext context)
        {
            List<Aposta> listaApostas = new List<Aposta>();
            List<Apostum> apostas = new List<Apostum>();

            //todas as apostas que nao estao arquivadas
            if (request.Nome == "")
            {
                apostas = await _dbContext.Aposta.Include(b => b.Utilizador)
                    .Where(x => x.Arquivada == false)
                    .OrderByDescending(x => x.DataRegisto).ToListAsync();
            }
            else
            {   //Lista de apostas desse nome
                var utilizador = await _dbContext.Utilizadors.Where(x => x.Nome == request.Nome).FirstOrDefaultAsync();
                if (utilizador != null)
                {
                    apostas = await _dbContext.Aposta.Include(x => x.Utilizador)
                        .Where(x => x.UtilizadorId == utilizador.Id)
                        .OrderByDescending(x => x.DataRegisto).ToListAsync();
                }
            }
            foreach (var x in apostas)
            {
                var _aposta = new Aposta { Nome = x.Utilizador.Nome, Chave = x.Chave, Data = x.DataRegisto };
                listaApostas.Add(_aposta);
            }
            return await Task.FromResult(new ListaDeApostas { Aposta = { listaApostas } });
        }

    }

}

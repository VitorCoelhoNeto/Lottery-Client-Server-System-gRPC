using Grpc.Core;
using Grpc.Net.Client;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUtilizador
{
    public partial class FormApostar : Form
    {
        private string userName;
        private GrpcChannel channel;
        public FormApostar(string _Username, GrpcChannel _channel)
        {
            InitializeComponent();
            userName = _Username;
            channel = _channel;
        }

        private void buttonApostar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int[] numeros = new int[5];
            int[] estrelas = new int[2];

            int i = 0;
            Int32.TryParse(textBox1.Text, out numeros[i++]);
            Int32.TryParse(textBox2.Text, out estrelas[i++]);

            string numerosString = textBox1.Text;
            string estrelasString = textBox2.Text;
            string chave = numerosString + " + " + estrelasString;

            Aposta aposta = new Aposta { Nome = userName, Chave = chave, Data = DateTime.Now.ToString() };

            PedidoAposta pedido = new PedidoAposta { Aposta = aposta };

            try
            {
                var cliente = new Euromilhoes.EuromilhoesClient(channel);
                var resposta = cliente.RegistarAposta(pedido);
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC","Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                //lista das apostas com esse nome
                var cliente = new Euromilhoes.EuromilhoesClient(channel);
                var resposta = cliente.ListarApostas(new PedidoListarApostas { Nome = userName });
                foreach (var x in resposta.Aposta)
                {
                    listView1.Items.Add(new ListViewItem(new[] { x.Nome, x.Data, x.Chave }));
                }
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC", "Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonListaApostas_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                var cliente = new Euromilhoes.EuromilhoesClient(channel);
                var resposta = cliente.ListarApostas(new PedidoListarApostas { Nome = userName });
                foreach (var x in resposta.Aposta)
                {
                    listView1.Items.Add(new ListViewItem(new[] { x.Nome, x.Data, x.Chave }));
                }
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC", "Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

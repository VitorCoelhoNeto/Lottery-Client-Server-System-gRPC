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
    public partial class FormListaApostas : Form
    {
        private string userName;
        private GrpcChannel channel;
        public FormListaApostas(string userName, GrpcChannel channel)
        {
            InitializeComponent();
            listView1.Items.Clear();
            try
            {
                // enviar nome do utilizador para o servidor
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

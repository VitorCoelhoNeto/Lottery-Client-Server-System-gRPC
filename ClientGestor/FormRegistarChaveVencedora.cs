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

namespace ClientGestor
{
    public partial class FormRegistarChaveVencedora : Form
    {
        private GrpcChannel channel;
        public FormRegistarChaveVencedora(GrpcChannel _channel)
        {
            InitializeComponent();
            channel = _channel;
        }

        private void buttonApostar_Click(object sender, EventArgs e)
        {
        }

        private void buttonListaApostas_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                var cliente = new Euromilhoes.EuromilhoesClient(channel);
                var resposta = cliente.ListarApostas(new PedidoListarApostas { Nome = "" });

                foreach (var aposta in resposta.Aposta)
                {
                    listView1.Items.Add(new ListViewItem(new[]
                    {
                        aposta.Nome, aposta.Data, aposta.Chave
                    }));
                }
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC.","Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

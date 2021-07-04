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

namespace ClientAdministrador
{
    public partial class FormListaUtilizadores : Form
    {
        public FormListaUtilizadores(GrpcChannel channel)
        {
            InitializeComponent();
            try
            {
                var cliente = new Euromilhoes.EuromilhoesClient(channel);
                var resposta = cliente.ListarUtilizadores(new PedidoListarUtilizadores());

                foreach (var user in resposta.Utilizador)
                {
                    listView1.Items.Add(new ListViewItem(new[] { user }));
                }
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC.","Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

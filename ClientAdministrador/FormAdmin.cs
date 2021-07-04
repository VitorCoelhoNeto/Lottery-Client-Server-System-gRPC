using Grpc.Core;
using Grpc.Net.Client;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAdministrador
{
        public partial class FormAdmin : Form
    {
        private GrpcChannel channel;
        public FormAdmin()
        {
            InitializeComponent();
            try
            {
                var httpHandler = new HttpClientHandler();
                httpHandler.ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                channel = GrpcChannel.ForAddress("https://25.74.158.59:5001",
                    new GrpcChannelOptions { HttpHandler = httpHandler });
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC", "Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonListaUtilizadores_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormListaUtilizadores f = new FormListaUtilizadores(channel))
                f.ShowDialog();
            Show();
        }

        private void buttonListaApostas_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormListaApostas f = new FormListaApostas(channel))
                f.ShowDialog();
            Show();
        }

        private void buttonArquivarApostas_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Euromilhoes.EuromilhoesClient(channel);
                var resposta = cliente.ArquivarApostas(new PedidoArquivarApostas());
                MessageBox.Show(resposta.Resultado ? "Apostas arquivadas com Sucesso." : "Erro a arquivar apostas.");
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC.","Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using Grpc.Net.Client;
using System.Net.Http;

namespace ClientUtilizador
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        private GrpcChannel channel;
        public FormLogin()
        {
            InitializeComponent();
            try
            {
                // Criar o canal Grpc para ligação ao servidor
                var httpHandler = new HttpClientHandler();
                httpHandler.ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                channel = GrpcChannel.ForAddress("https://25.74.158.59:5001",
                    new GrpcChannelOptions { HttpHandler = httpHandler });
            }
            catch (RpcException)
            {
                MessageBox.Show("Erro no serviço gRPC","Erro no serviço gRPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length >= 3 || textBoxNome.Text.Length < 10)
            {
                Hide();
                using (FormMenuUtilizador f = new FormMenuUtilizador(textBoxNome.Text, channel))
                    f.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Tente Novamente um nome entre 3 e 10 caracteres","Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

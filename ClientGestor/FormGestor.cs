using Grpc.Core;
using Grpc.Net.Client;
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

namespace ClientGestor
{
    public partial class FormGestor : Form
    {
        private GrpcChannel channel;
        public FormGestor()
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

        private void buttonVencedores_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormChavesVencedoras f = new FormChavesVencedoras(channel))
                f.ShowDialog();
            Show();
        }

        private void buttonRegistarVencedora_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormRegistarChaveVencedora f = new FormRegistarChaveVencedora(channel))
                f.ShowDialog();
            Show();
        }
    }
}

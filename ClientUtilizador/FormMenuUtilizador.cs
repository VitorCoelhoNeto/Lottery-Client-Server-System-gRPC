using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientUtilizador
{
    public partial class FormMenuUtilizador : Form
    {
        private string userName;
        private GrpcChannel channel;
        public FormMenuUtilizador(string _username, GrpcChannel _channel)
        {
            InitializeComponent();
            userName = _username;
            labelNome.Text = userName;
            channel = _channel;
        }
        private void buttonApostar_Click_1(object sender, EventArgs e)
        {
            Hide();
            using (FormApostar f = new FormApostar(userName, channel))
                f.ShowDialog();
            Show();
        }

        private void buttonApostas_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormListaApostas f = new FormListaApostas(userName, channel))
                f.ShowDialog();
            Show();
        }
    }
}

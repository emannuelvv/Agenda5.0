using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            formMenuTarefa Tela = new formMenuTarefa();
            Tela.Show();
            this.Hide();
        }

        private void bntContato_Click(object sender, EventArgs e)
        {
            formMenuContato Tela = new formMenuContato();
            Tela.Show();
            this.Hide();
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            formMenuCompromisso Tela = new formMenuCompromisso();
            Tela.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

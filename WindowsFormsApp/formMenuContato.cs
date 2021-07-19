using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
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
    public partial class formMenuContato : Form
    {
        private ControladorContato controladorContato;
        public formMenuContato()
        {
            controladorContato = new ControladorContato();
            InitializeComponent();
            dgvContato.DataSource = PopulandoGridContato();
        }
        public void EditarContato()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string email = mskEmail.Text;
            string telefone = maskTelefone.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            string resultadoValidacao = contato.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                controladorContato.Editar(id, contato);
            }
            else
            {
                MessageBox.Show(resultadoValidacao);
                
            }
        }

            private void InserirContato()
        {
            string nome = txtNome.Text;
            string email = mskEmail.Text;
            string telefone = maskTelefone.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            string resultadoValidacao = contato.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                controladorContato.InserirNovo(contato);
            }
            else
            {
                MessageBox.Show(resultadoValidacao);
                
            }

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            InserirContato();
            dgvContato.DataSource = PopulandoGridContato();
        }
        public void ExcluirContato()
        {
            int id = Convert.ToInt32(txtId.Text);
            controladorContato.Excluir(id);
        }

        private DataTable PopulandoGridContato()
        {
            DataTable formandoColunas = Colunas();
            List<Contato> contatos = controladorContato.SelecionarTodos();
            PopulandoLinhas(formandoColunas, contatos);

            return formandoColunas;
        }

        private void PopulandoLinhas(DataTable formandoColunas, List<Contato> contatos)
        {
            foreach (var contato in contatos)
            {
                var novaLinha = formandoColunas.NewRow();

                novaLinha["ID"] = contato.Id;
                novaLinha["Nome"] = contato.Nome;
                novaLinha["Email"] = contato.Email;
                novaLinha["Telefone"] = contato.Telefone;

                formandoColunas.Rows.Add(novaLinha);
            }
        }

        private static DataTable Colunas()
        {
            DataTable formandoColunas = new DataTable();

            formandoColunas.Columns.Add("ID");
            formandoColunas.Columns.Add("Nome");
            formandoColunas.Columns.Add("Email");
            formandoColunas.Columns.Add("Telefone");
            return formandoColunas;
        }

        private void btnEditContato_Click(object sender, EventArgs e)
        {
            EditarContato();
            dgvContato.DataSource = PopulandoGridContato();
        }

        private void btnDeleteContato_Click(object sender, EventArgs e)
        {
            ExcluirContato();
            dgvContato.DataSource = PopulandoGridContato();
        }

        private void dgvContato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvContato.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(txtId.Text);

            Contato contato = controladorContato.SelecionarPorId(id);

            txtId.Text = contato.Id.ToString();
            txtNome.Text = contato.Nome;
            mskEmail.Text = contato.Email;
            maskTelefone.Text = contato.Telefone;
            txtCargo.Text = contato.Cargo;
            txtEmpresa.Text = contato.Empresa;

        }
    }
}

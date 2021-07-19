using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
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
    public partial class formMenuCompromisso : Form
    {
        private Contato contato;
        private ControladorCompromisso controladorCompromisso;
        public formMenuCompromisso()
        {
            controladorCompromisso = new ControladorCompromisso();
            
            InitializeComponent();

            dgvCompromisso.DataSource = PopulandoGridTodosCompromissos();
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

        public void InserirCompromisso()
        {
            string assunto = textAssunto.Text;
            string local = txtLocal.Text;
            string link = maskLink.Text;
            DateTime data = dateInicial.Value;
            TimeSpan horaInicio = Convert.ToDateTime(mskInicio.Text).TimeOfDay;
            TimeSpan horaTermino = Convert.ToDateTime(mskTermino.Text).TimeOfDay;
            Compromisso compromisso = null;

            compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
            string resultadoValidacao = compromisso.Validar();
            bool verificaHorario = controladorCompromisso.VerificarHorarioOcupado(data, horaInicio, horaTermino);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (verificaHorario == false)
                {
                    controladorCompromisso.InserirNovo(compromisso);
                }

                else
                {
                    resultadoValidacao = "";
                    resultadoValidacao += "Nesta data e horário já tem um compromisso agendado";
                    MessageBox.Show(resultadoValidacao);

                }

            }
            else
            {

                MessageBox.Show(resultadoValidacao);

            }
        }
        public void EditarCompromisso()
        {
            int id = Convert.ToInt32(txtId.Text);
            string assunto = textAssunto.Text;
            string local = txtLocal.Text;
            string link = maskLink.Text;
            DateTime data = dateInicial.Value;
            TimeSpan horaInicio = Convert.ToDateTime(mskInicio.Text).TimeOfDay;
            TimeSpan horaTermino = Convert.ToDateTime(mskTermino.Text).TimeOfDay;
            Compromisso compromisso = null;
            bool verificaHorario = controladorCompromisso.VerificarHorarioOcupado(data, horaInicio, horaTermino);
            compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
            string resultadoValidacao = compromisso.Validar();


            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (verificaHorario == false)
                {
                    controladorCompromisso.Editar(id, compromisso);
                }
                else
                {
                    resultadoValidacao = "";
                    resultadoValidacao += "Nesta data e horário já tem um compromisso agendado";
                    MessageBox.Show(resultadoValidacao);

                }

            }
            else
            {

                MessageBox.Show(resultadoValidacao);

            }
        }

        private DataTable PopulandoGridTodosCompromissos()
        {
            DataTable formandoColunas = Colunas();
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();
            PopulandoLinhas(formandoColunas, compromissos);

            return formandoColunas;
        }

        private DataTable PopulandoGridCompromissosPassados()
        {
            DataTable formandoColunas = Colunas();
            List<Compromisso> compromissos = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now);
            PopulandoLinhas(formandoColunas, compromissos);

            return formandoColunas;
        }

        private DataTable PopulandoGridCompromissosFuturos()
        {
            DataTable formandoColunas = Colunas();
            List<Compromisso> compromissos = controladorCompromisso.SelecionarCompromissosFuturos(DateTime.Now, dateInicial.Value);
            PopulandoLinhas(formandoColunas, compromissos);

            return formandoColunas;
        }

        private void PopulandoLinhas(DataTable formandoColunas, List<Compromisso> compromissos)
        {

            foreach (var compromisso in compromissos)
            {
                var novaLinha = formandoColunas.NewRow();

                novaLinha["ID"] = compromisso.Id;
                novaLinha["Assunto"] = compromisso.Assunto;
                novaLinha["Data"] = compromisso.Data.ToShortDateString();
                if (compromisso.Contato != null)
                {
                    novaLinha["Contato"] = compromisso.Contato.Nome;
                }
                formandoColunas.Rows.Add(novaLinha);
            }
        }
        public void ExcluirCompromisso()
        {
            int id = Convert.ToInt32(txtId.Text);
            controladorCompromisso.Excluir(id);

            dgvCompromisso.DataSource = PopulandoGridTodosCompromissos();
            dgvCompromisso.DataSource = PopulandoGridCompromissosPassados();
            dgvCompromisso.DataSource = PopulandoGridCompromissosFuturos();
        }
        private static DataTable Colunas()
        {
            DataTable formandoColunas = new DataTable();

            formandoColunas.Columns.Add("ID");
            formandoColunas.Columns.Add("Assunto");
            formandoColunas.Columns.Add("Data");
            formandoColunas.Columns.Add("Contato");
            return formandoColunas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMenuBuscarContato buscarContatoMenu = new formMenuBuscarContato();
            buscarContatoMenu.ShowDialog();
            contato = buscarContatoMenu.Contato;
            if (contato != null)
            {
                txtContatoBuscar.Text = contato.Nome;
            }
        }

        private void btnAddCompromisso_Click(object sender, EventArgs e)
        {
            InserirCompromisso();
            dgvCompromisso.DataSource = PopulandoGridTodosCompromissos();
            
        }

        private void btnEditCompromisso_Click(object sender, EventArgs e)
        {
            EditarCompromisso();
            dgvCompromisso.DataSource = PopulandoGridTodosCompromissos();
            
        }

        private void btnDeleteCompromisso_Click(object sender, EventArgs e)
        {
            ExcluirCompromisso();
            dgvCompromisso.DataSource = PopulandoGridTodosCompromissos();
            
        }

        private void dgvCompromisso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCompromisso.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(txtId.Text);

            Compromisso compromisso = controladorCompromisso.SelecionarPorId(id);

            txtId.Text = compromisso.Id.ToString();
            if (compromisso.Contato != null)
            {
                txtIdCompromisso.Text = compromisso.Contato.Nome;
            }
            else
            {
                txtIdCompromisso.Text = String.Empty;
            }
            textAssunto.Text = compromisso.Assunto;
            maskLink.Text = compromisso.Link;
            txtLocal.Text = compromisso.Local;
            dateInicial.Value = compromisso.Data;
            mskInicio.Text = compromisso.HoraInicio.ToString();
            mskTermino.Text = compromisso.HoraTermino.ToString();
            contato = compromisso.Contato;

            
        }
    }
}



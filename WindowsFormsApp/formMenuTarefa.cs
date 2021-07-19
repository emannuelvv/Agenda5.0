using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
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
    public partial class formMenuTarefa : Form

    {
        private ControladorTarefa controladorTarefa;


        public formMenuTarefa()
        {
            controladorTarefa = new ControladorTarefa();
            InitializeComponent();
            dateCriacao.Value = DateTime.Now;
            dgvTarefa.DataSource = PopulandoGridTodasTarefas();
        }

        

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textPrioridade.Text = tckPrioridade.Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InserirTarefa()
        {
            string titulo = txtTitulo.Text;
            DateTime dataInicial = dateCriacao.Value;
            int numeroPrioridade = Convert.ToInt32(tckPrioridade.Value);

            Tarefa tarefa = new Tarefa(titulo, dataInicial, (PrioridadeEnum)numeroPrioridade);

            string resultadoValidacao = tarefa.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                controladorTarefa.InserirNovo(tarefa);
            }
            else
            {
                MessageBox.Show(resultadoValidacao);
            }
        }
        private void ExcluirTarefa()
        {
            int id = Convert.ToInt32(txtId.Text);
            controladorTarefa.Excluir(id);
        }

        private void EditarTarefa()
        {
            int id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;
            DateTime dataInicial = dateCriacao.Value;
            DateTime dataConclusao = dateConclusao.Value;
            int numeroPrioridade = Convert.ToInt32(tckPrioridade.Text);
            int percentual = Convert.ToInt32(txtPercentual.Text);

            Tarefa tarefa = new Tarefa(titulo, dataInicial, (PrioridadeEnum)numeroPrioridade);
            tarefa.AtualizarPercentual(percentual, dataConclusao);

            string resultadoValidacao = tarefa.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                controladorTarefa.Editar(id, tarefa);
            }
            else
            {
                MessageBox.Show(resultadoValidacao);
                
            }
        }


            private static void PopulandoLinhas(DataTable formandoColunas, List<Tarefa> tarefas)
            {
                foreach (var tarefa in tarefas)
                {
                    var novaLinha = formandoColunas.NewRow();

                    novaLinha["ID"] = tarefa.Id;
                    novaLinha["Titulo"] = tarefa.Titulo;
                    novaLinha["Prioridade"] = tarefa.Prioridade;
                    novaLinha["Percentual"] = tarefa.Percentual;

                    formandoColunas.Rows.Add(novaLinha);
                }
            }

            private static DataTable Colunas()
            {
                DataTable formandoColunas = new DataTable();

                formandoColunas.Columns.Add("ID");
                formandoColunas.Columns.Add("Titulo");
                formandoColunas.Columns.Add("Prioridade");
                formandoColunas.Columns.Add("Percentual");
                return formandoColunas;
            }

            private DataTable PopularGridTarefasConcluidas()
            {


                DataTable formandoColunas = Colunas();
                List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasConcluidas();
                PopulandoLinhas(formandoColunas, tarefas);

                return formandoColunas;
            }

            private DataTable PopulandoGridTarefasPendentes()
            {
                DataTable formandoColunas = Colunas();
                List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasPendentes();
                PopulandoLinhas(formandoColunas, tarefas);

                return formandoColunas;
            }

            private DataTable PopulandoGridTodasTarefas()
            {
                DataTable formandoColunas = Colunas();
                List<Tarefa> tarefas = controladorTarefa.SelecionarTodos();
                PopulandoLinhas(formandoColunas, tarefas);

                return formandoColunas;
            }

        private void btnAddTarefa_Click(object sender, EventArgs e)
        {
            InserirTarefa();
            dgvTarefa.DataSource = PopulandoGridTodasTarefas();
        }

        private void btnEditTarefa_Click(object sender, EventArgs e)
        {
            EditarTarefa();
            dgvTarefa.DataSource = PopulandoGridTodasTarefas();
        }

        private void dgvTarefa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTarefa.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(txtId.Text);

            Tarefa tarefa = controladorTarefa.SelecionarPorId(id);

            txtId.Text = tarefa.Id.ToString();
            txtTitulo.Text = tarefa.Titulo;
            txtPercentual.Text = tarefa.Percentual.ToString();
            tckPrioridade.Text = tarefa.Prioridade.Chave.ToString();
            dateCriacao.Value = tarefa.DataCriacao;
            dateConclusao.Value = tarefa.DataCriacao;
        }

        private void btnDeleteTarefa_Click(object sender, EventArgs e)
        {
            ExcluirTarefa();
            dgvTarefa.DataSource = PopulandoGridTodasTarefas();
        }
    }
}


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
    public partial class formMenuBuscarContato : Form
    {

        private ControladorContato controladorContato;

        public formMenuBuscarContato()
        {
            controladorContato = new ControladorContato();
            InitializeComponent();
            dgvSelectContato.DataSource = PopulandoGridContato();
        }
        private Contato contato;
        public Contato Contato { get => contato; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private DataTable PopulandoGridContato()
        {
            DataTable formandoColunas = Colunas();
            List<Contato> contatos = controladorContato.SelecionarTodos();
            PopulandoLinhas(formandoColunas, contatos);

            return formandoColunas;
        }


        private static void PopulandoLinhas(DataTable formandoColunas, List<Contato> contatos)
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

        private void dgvSelectContato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string recebeId = dgvSelectContato.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(recebeId);

            contato = controladorContato.SelecionarPorId(id);

            Dispose();
        }
    }
}

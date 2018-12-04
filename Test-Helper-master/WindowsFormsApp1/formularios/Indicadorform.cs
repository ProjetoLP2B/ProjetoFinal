using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Log;

namespace WindowsFormsApp1
{
    public partial class Indicadorform : Form
    {
        Usuario user = null;
        public Indicadorform(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            Atualizar_DataGrid();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void btnInserirIndicador_Click(object sender, EventArgs e)
        {
            InserirIndicador telainserirInd = new InserirIndicador(user);
            if(telainserirInd.ShowDialog() == DialogResult.OK) Atualizar_DataGrid();

        }

        private void Indicadorform_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlterarIndicador_Click(object sender, EventArgs e)
        {
            Indicador indicador = new Indicador();
            try
            {
                indicador.id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                indicador.nome = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
                indicador.observacao = Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
                indicador.descricao = Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
            }
            catch
            {

            }
            finally
            {
                InserirIndicador alterarIndicador = new InserirIndicador(indicador,user);
                if(alterarIndicador.ShowDialog() == DialogResult.OK)
                    Atualizar_DataGrid();
            }
        }

        private void btnDeletarIndicador_Click(object sender, EventArgs e)
        {
            const string message = "Você deseja realmente excluir ?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            int cod = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            LogDAO logdao = new LogDAO();
            logdao.inserir(user, "Indicador Deletado id=" + cod + ", id user =" + user.id);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                IndicadorDao dao = new IndicadorDao();
                dao.exclui(Form1.lista_indicadores[dataGridView1.CurrentRow.Index]);
                Atualizar_DataGrid();
            }

           



        }
        public void Atualizar_DataGrid()
        {
            IndicadorDao dao = new IndicadorDao();
            Form1.lista_indicadores = dao.List();
            dataGridView1.DataSource = Form1.lista_indicadores;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            Indicador indicador = new Indicador();

            try
            {
                indicador.id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                indicador.nome = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
                indicador.observacao = Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
                indicador.descricao = Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
            }
            catch
            {

            }
            finally
            {
                InserirIndicador alterarIndicador = new InserirIndicador(indicador);
                alterarIndicador.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AtualizarPes_DataGrid(string query)
        {
            IndicadorDao dao = new IndicadorDao();
            Form1.lista_indicadores = dao.Pesquisar(query);
            dataGridView1.DataSource = Form1.lista_indicadores;
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa;
            string tipoPesquisa;
            string query;
            int indice;
            pesquisa = txtPesquisar.Text;
            tipoPesquisa = cbxPesquisar.Text;
            indice = cbxPesquisar.SelectedIndex;

            switch (indice)
            {
                case 0 :// id
                    query = "select * from Indicador Where Id_Indicador=" + pesquisa;
                    AtualizarPes_DataGrid(query);
                    break;

                case 1://nome
                    
                    query = "select * from Indicador Where Nome_Indicador like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);
                    break;

                case 2://Descriçao
                    query = "select * from Indicador Where Descricao_Indicador like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);

                    break;

                case 3:// Observaçao
                    query = "select * from Indicador Where Observacao_Indicador like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);

                    break;
                default:
                       MessageBox.Show("Selecione um campo para pesquisar");
                break;
            }

        }
    }
}

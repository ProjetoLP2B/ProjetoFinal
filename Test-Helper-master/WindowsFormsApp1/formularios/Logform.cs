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
    public partial class Usuarioform : Form
    {
        
        public Usuarioform()
        {
            InitializeComponent();
            LogDAO logdao = new LogDAO();
            Form1.lista_log = logdao.List();
            dataGridView1.DataSource = Form1.lista_log;
        }


        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        public void AtualizarPes_DataGrid(string query)
        {
            LogDAO logdao = new LogDAO();
            Form1.lista_log = logdao.Pesquisar(query);
            dataGridView1.DataSource = Form1.lista_log;

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
                case 0:// id
                    query = "select * from Log Where id_log=" + pesquisa;
                    AtualizarPes_DataGrid(query);
                    break;

                case 1://Id_User

                    query = "select * from Log Where Id_User=" + pesquisa;
                    AtualizarPes_DataGrid(query);
                    break;

                case 2://Data de alteraçao
                    query = "select * from Log Where Data_Alteracao like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);

                    break;

                case 3:// Descriçao da alteraçao
                    query = "select * from Log Where Descricao_Registro like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);

                    break;
                default:
                    MessageBox.Show("Selecione um campo para pesquisar");
                    break;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

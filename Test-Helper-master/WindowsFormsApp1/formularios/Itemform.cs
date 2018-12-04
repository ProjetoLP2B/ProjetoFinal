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
    public partial class Itemform : Form
    {
        Usuario user = null;
        public Itemform(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            Atualizar_DataGrid();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnDeletarItem_Click(object sender, EventArgs e)
        {
            const string message = "Você deseja realmente excluir ?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            int cod = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            LogDAO logdao = new LogDAO();
            logdao.inserir(user, "Item Deletado id=" + cod + ", id user =" + user.id);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                ItemDao dao = new ItemDao();
                dao.exclui(Form1.lista_item[dataGridView1.CurrentRow.Index]);
                Atualizar_DataGrid();
            }
      
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            try
            {
                item.id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                item.nome = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
                item.observacao = Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
                item.descricao = Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
            }
            catch
            {

            }
            finally
            {
                InserirItem alteraritem = new InserirItem(item,user);
                if (alteraritem.ShowDialog() == DialogResult.OK)
                {
                    Atualizar_DataGrid();
                }
            }
        }
        
        private void btnInserirItem_Click(object sender, EventArgs e)
        {
           InserirItem telainserir = new InserirItem(user);
            Log.LogDAO logdao = new Log.LogDAO();
            if (telainserir.ShowDialog() == DialogResult.OK) {
                Atualizar_DataGrid();
            }
        }

        public void Atualizar_DataGrid()
        {
            ItemDao dao = new ItemDao();
            Form1.lista_item = dao.List();
            dataGridView1.DataSource = Form1.lista_item;
        }

        private void Itemform_Load(object sender, EventArgs e)
        {

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            try
            {
                item.id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                item.nome = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
                item.observacao = Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
                item.descricao = Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
            }
            catch
            {

            }
            finally
            {
                InserirItem alteraritem = new InserirItem(item);
                alteraritem.Show();
            }
        }

        public void AtualizarPes_DataGrid(string query)
        {
            ItemDao dao = new ItemDao();
            Form1.lista_item = dao.Pesquisar(query);
            dataGridView1.DataSource = Form1.lista_item;
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
                    query = "select * from Item Where Id_Item=" + pesquisa;
                    AtualizarPes_DataGrid(query);
                    break;

                case 1://nome

                    query = "select * from Item Where Nome_Item like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);
                    break;

                case 2://Descriçao
                    query = "select * from Item Where Descricao_Item like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);

                    break;

                case 3:// Observaçao
                    query = "select * from Item Where Observacao_Item like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);

                    break;
                default:
                    MessageBox.Show("Selecione um campo para pesquisar");
                    break;
            }

        }
    }
}

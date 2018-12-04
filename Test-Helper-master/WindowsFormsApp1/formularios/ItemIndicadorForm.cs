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
    public partial class ItemIndicadorForm : Form
    {
        Usuario user = null;
        public ItemIndicadorForm(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            AtualizarDataGrid();
        }

        private void btnRelacionar_Click(object sender, EventArgs e)
        {
            RelacionarItemEIndicadorForm telarelacionar = new RelacionarItemEIndicadorForm(user);
            if(telarelacionar.ShowDialog() == DialogResult.OK) AtualizarDataGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarDataGrid()
        {
            ItemIndicadorDao dao = new ItemIndicadorDao();
            Form1.lista_itemindicador = dao.List();
            dataGridView1.DataSource = Form1.lista_itemindicador;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            const string message = "Você deseja realmente excluir ?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            int cod = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            LogDAO logdao = new LogDAO();
            logdao.inserir(user, "Item indicador Deletado id=" + cod + ", id user =" + user.id);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                ItemIndicadorDao dao = new ItemIndicadorDao();
                dao.exclui(Form1.lista_itemindicador[dataGridView1.CurrentRow.Index]);
                AtualizarDataGrid();
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ItemIndicador itemind = new ItemIndicador();
            try
            {
                itemind.id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                itemind.nome = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
                itemind.codigo_indicador = Convert.ToInt32(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
                itemind.codigo_item = Convert.ToInt32(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
                itemind.descricao = Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value);
                itemind.observacao = Convert.ToString(dataGridView1[5, dataGridView1.CurrentRow.Index].Value);
            }
            catch
            {

            }
            finally
            {
                RelacionarItemEIndicadorForm telarelacionar = new RelacionarItemEIndicadorForm(user, itemind);
                if (telarelacionar.ShowDialog() == DialogResult.OK) AtualizarDataGrid();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            ItemIndicador itemind = new ItemIndicador();
            try
            {
                itemind.id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                itemind.nome = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
                itemind.codigo_indicador = Convert.ToInt32(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
                itemind.codigo_item = Convert.ToInt32(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
                itemind.descricao = Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value);
                itemind.observacao = Convert.ToString(dataGridView1[5, dataGridView1.CurrentRow.Index].Value);
            }
            catch
            {

            }
            finally
            {
                RelacionarItemEIndicadorForm telarelacionar = new RelacionarItemEIndicadorForm(itemind);
                if (telarelacionar.ShowDialog() == DialogResult.OK) AtualizarDataGrid();
            }
        }

        private void ItemIndicadorForm_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarPesDataGrid(string query)
        {
            ItemIndicadorDao dao = new ItemIndicadorDao();
            Form1.lista_itemindicador = dao.Pesquisar(query);
            dataGridView1.DataSource = Form1.lista_itemindicador;
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
                    query = "select * from Item_Indicador Where Id_ItemIndicador =" + pesquisa;
                    AtualizarPesDataGrid(query);
                    break;

                case 1://nome

                    query = "select * from Item_Indicador Where Nome_ItemIndicador like '%" + pesquisa + "%'";
                    AtualizarPesDataGrid(query);
                    break;

                case 2://Item  
                    query = "select * from Item_Indicador Where Codigo_Item=" + pesquisa;
                    AtualizarPesDataGrid(query);

                    break;

                case 3://indicador 
                    query = "select * from Item_Indicador Where Codigo_Indicador= " + pesquisa;
                    AtualizarPesDataGrid(query);
                
                    break;
                case 4://Descrição
                    query = "select * from Item_Indicador Where Descricao_ItemIndicador like '%" + pesquisa + "%'";
                    AtualizarPesDataGrid(query);

                    break;
                case 5://Observação
                    query = "select * from Item_Indicador Where Observacao_ItemIndicador like '%" + pesquisa + "%'";
                    AtualizarPesDataGrid(query);

                    break;
                default:
                    MessageBox.Show("Selecione um campo para pesquisar");
                    break;
            }



        }
    }
}

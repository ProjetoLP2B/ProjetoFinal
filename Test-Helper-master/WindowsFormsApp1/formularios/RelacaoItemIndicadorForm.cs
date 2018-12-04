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
    public partial class RelacaoItemIndicadorForm : Form
    {
        Usuario user = null;
        public RelacaoItemIndicadorForm(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            Atualizar_DataGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelacionar_Click(object sender, EventArgs e)
        {
            RelacionarEntreItensIndicadoresForm telarelacionar = new RelacionarEntreItensIndicadoresForm(user);
            if(telarelacionar.ShowDialog() == DialogResult.OK)Atualizar_DataGrid();
        }

        private void RelacaoItemIndicadorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            RelacaoItemIndicador relacao = new RelacaoItemIndicador();
            try
            {
                relacao.id = Convert.ToInt32(dtgRelacao[0, dtgRelacao.CurrentRow.Index].Value);
                relacao.nome = Convert.ToString(dtgRelacao[1, dtgRelacao.CurrentRow.Index].Value);
                relacao.cod1 = Convert.ToInt32(dtgRelacao[2, dtgRelacao.CurrentRow.Index].Value);
                relacao.cod2 = Convert.ToInt32(dtgRelacao[3, dtgRelacao.CurrentRow.Index].Value);
                relacao.descricao = Convert.ToString(dtgRelacao[4, dtgRelacao.CurrentRow.Index].Value);
                relacao.observacao = Convert.ToString(dtgRelacao[5, dtgRelacao.CurrentRow.Index].Value);
            }
            catch
            {

            }
            finally
            {
                RelacionarEntreItensIndicadoresForm telarelacionar = new RelacionarEntreItensIndicadoresForm(user,relacao);
                if (telarelacionar.ShowDialog() == DialogResult.OK) Atualizar_DataGrid();
            }
        }
        public void Atualizar_DataGrid()
        {
            RelacaoItemIndicadoresDao dao = new RelacaoItemIndicadoresDao();
            Form1.lista_relacao = dao.List();
            dtgRelacao.DataSource = Form1.lista_relacao;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            const string message = "Você deseja realmente excluir ?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            int cod = Convert.ToInt32(dtgRelacao[0, dtgRelacao.CurrentRow.Index].Value);
            LogDAO logdao = new LogDAO();
            logdao.inserir(user, "Relaçao Deletada id=" + cod + ", id user =" + user.id);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                RelacaoItemIndicadoresDao dao = new RelacaoItemIndicadoresDao();
                dao.exclui(Form1.lista_relacao[dtgRelacao.CurrentRow.Index]);
                Atualizar_DataGrid();
            }
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            RelacaoItemIndicador relacao = new RelacaoItemIndicador();
            try
            {
                relacao.id = Convert.ToInt32(dtgRelacao[0, dtgRelacao.CurrentRow.Index].Value);
                relacao.nome = Convert.ToString(dtgRelacao[1, dtgRelacao.CurrentRow.Index].Value);
                relacao.cod1 = Convert.ToInt32(dtgRelacao[2, dtgRelacao.CurrentRow.Index].Value);
                relacao.cod2 = Convert.ToInt32(dtgRelacao[3, dtgRelacao.CurrentRow.Index].Value);
                relacao.descricao = Convert.ToString(dtgRelacao[4, dtgRelacao.CurrentRow.Index].Value);
                relacao.observacao = Convert.ToString(dtgRelacao[5, dtgRelacao.CurrentRow.Index].Value);
            }
            catch
            {

            }
            finally
            {
                RelacionarEntreItensIndicadoresForm telarelacionar = new RelacionarEntreItensIndicadoresForm(relacao);
                telarelacionar.Show();
            }
        }
        public void AtualizarPes_DataGrid(string query)
        {
            RelacaoItemIndicadoresDao dao = new RelacaoItemIndicadoresDao();
            Form1.lista_relacao = dao.Pesquisar(query);
            dtgRelacao.DataSource = Form1.lista_relacao;
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
                    query = "select * from Relacao_Item_Indicador Where Id_Relacao_Item_Indicador =" + pesquisa;
                    AtualizarPes_DataGrid(query);
                    break;

                case 1://nome

                    query = "select * from Relacao_Item_Indicador Where Nome_Relacao_ItemIndicador like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);
                    break;

                case 2://Item indicador 1
                    query = "select * from Relacao_Item_Indicador Where Codigo1_ItemIndicador=" + pesquisa ;
                    AtualizarPes_DataGrid(query);

                    break;

                case 3:// Item indicador 2
                    query = "select * from Relacao_Item_Indicador Where Codigo2_ItemIndicador= "+ pesquisa;
                    AtualizarPes_DataGrid(query);

                    break;
                case 4://Descrição
                    query = "select * from Relacao_Item_Indicador Where Descricao_Relacao_ItemIndicador like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);

                    break;
                case 5://Observação
                    query = "select * from Relacao_Item_Indicador Where Observacao_Relacao_ItemIndicador like '%" + pesquisa + "%'";
                    AtualizarPes_DataGrid(query);

                    break;
                default:
                    MessageBox.Show("Selecione um campo para pesquisar");
                    break;
            }


        }
    }
}

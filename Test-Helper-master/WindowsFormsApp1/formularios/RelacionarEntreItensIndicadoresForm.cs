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
    public partial class RelacionarEntreItensIndicadoresForm : Form
    {
        bool altera = false,exibir=false;
        Usuario user = null;
        RelacaoItemIndicador relacao = null;
        public RelacionarEntreItensIndicadoresForm(Usuario user)
        {
            this.user = user;
            exibir = false;
            altera = false;
            InitializeComponent();
            Atualizar_DataGrid();
        }

        public RelacionarEntreItensIndicadoresForm(Usuario user, RelacaoItemIndicador relacao)
        {
            this.relacao = relacao;
            this.user = user;
            InitializeComponent();
            label1.Text = "Alterar Relacao";
            this.Text = "Alterar Relacao";

            Atualizar_DataGrid();
            altera = true;
            exibir = false;
            for (int i = 0; i < dtgItemIndicador1.RowCount; i++)
            {
                if (Convert.ToInt32(dtgItemIndicador1[0, i].Value) == relacao.cod1)
                {
                    dtgItemIndicador1[2, i].Selected = true;
                }
                if (Convert.ToInt32(dtgItemIndicador2[0, i].Value) == relacao.cod2)
                {
                    dtgItemIndicador2[3, i].Selected = true;
                }
            }
            try
            {
                txtDescricao.Text = relacao.descricao;
                txtObservacao.Text = relacao.observacao;
                txtNome.Text = relacao.nome;
                txtid.Text = relacao.id.ToString();
            }
            catch
            { }
        }

        public RelacionarEntreItensIndicadoresForm(RelacaoItemIndicador relacao)
        {
            this.relacao = relacao;
            InitializeComponent();
            label1.Text = "Exibir Relacao";
            this.Text = "Exibir Relacao";

            Atualizar_DataGrid();
            altera = false;
            exibir = true;
            for (int i = 0; i < dtgItemIndicador1.RowCount; i++)
            {
                if (Convert.ToInt32(dtgItemIndicador1[0, i].Value) == relacao.cod1)
                {
                    dtgItemIndicador1[2, i].Selected = true;
                }
                if (Convert.ToInt32(dtgItemIndicador2[0, i].Value) == relacao.cod2)
                {
                    dtgItemIndicador2[3, i].Selected = true;
                }
            }
            try
            {
                txtDescricao.Text = relacao.descricao;
                txtObservacao.Text = relacao.observacao;
                txtNome.Text = relacao.nome;
                txtid.Text = relacao.id.ToString();
            }
            catch
            { }
        }

        private void btnCancelarNovaRelIndi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelacionarEntreItensIndicadoresForm_Load(object sender, EventArgs e)
        {
            if (exibir)
            {
                txtNome.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                txtObservacao.ReadOnly = true;
                button1.Visible = false;
                btnCancelarNovaRelIndi.Text = "Voltar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!exibir)
            {
                RelacaoItemIndicador relacao_atual = new RelacaoItemIndicador();
                relacao_atual.nome = txtNome.Text;
                relacao_atual.observacao = txtObservacao.Text;
                relacao_atual.descricao = txtDescricao.Text;
                relacao_atual.cod1 = Convert.ToInt32(dtgItemIndicador1[0, dtgItemIndicador1.CurrentRow.Index].Value);
                relacao_atual.cod2 = Convert.ToInt32(dtgItemIndicador2[0, dtgItemIndicador2.CurrentRow.Index].Value); ;
                RelacaoItemIndicadoresDao dao = new RelacaoItemIndicadoresDao();
                LogDAO logdao = new LogDAO();

                if (relacao_atual.nome != string.Empty && relacao_atual.observacao != string.Empty &&
                    relacao_atual.descricao != string.Empty)
                {
                    if (altera)
                    {
                        relacao_atual.id = Convert.ToInt32(txtid.Text);
                        dao.editar(relacao_atual);
                        logdao.inserir(user, "Relação entre item indicador Alterado nome=" + relacao_atual.nome + " id user=" + user.id);
                    }
                    else
                    {
                        dao.inserir(relacao_atual);
                        logdao.inserir(user, "Relação entre item indicador Alterado nome=" + relacao_atual.nome +", id user=" + user.id);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos");
                }



            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Atualizar_DataGrid()
        {
            ItemIndicadorDao dao = new ItemIndicadorDao();
            Form1.lista_itemindicador = dao.List();
            dtgItemIndicador1.DataSource = Form1.lista_itemindicador;
            dao = new ItemIndicadorDao();
            Form1.lista_itemindicador = dao.List();
            dtgItemIndicador2.DataSource = Form1.lista_itemindicador;
        }
    }
}

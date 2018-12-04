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
    public partial class RelacionarItemEIndicadorForm : Form
    {
        bool altera = false;
        bool exibir = false;
        Usuario user = null;
        ItemIndicador relacao = null;
        public RelacionarItemEIndicadorForm(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            ItemDao itemdao = new ItemDao();
            dtgItens.DataSource = itemdao.List();
            IndicadorDao indicadoresdao = new IndicadorDao();
            dtgIndicadores.DataSource = indicadoresdao.List();
            altera = false;
            exibir = false;
        }

        public RelacionarItemEIndicadorForm(Usuario user, ItemIndicador relacao)
        {

            this.user = user;
            this.relacao = relacao;
            InitializeComponent();
          //  label1.Text = "Alterar Relacao";
            this.Text = "Alterar Relacao";
            ItemDao itemdao = new ItemDao();
            txtDescricao.Text = relacao.descricao;
            txtObervacao.Text = relacao.observacao;
            txtNome.Text = relacao.nome;
            txtId.Text = relacao.id.ToString();
            dtgItens.DataSource = itemdao.List();
            IndicadorDao indicadoresdao = new IndicadorDao();
            dtgIndicadores.DataSource = indicadoresdao.List();
            altera = true;
            exibir = false;
            for (int i = 0; i < dtgIndicadores.RowCount; i++)
            {
                bool limite = false;
                if (Convert.ToInt32(dtgIndicadores[0, i].Value) == relacao.codigo_item)
                {
                    dtgIndicadores[0, i].Selected = true;
                }

                if (i == dtgItens.RowCount - 1) limite = true;
                if (i < dtgItens.RowCount)
                {
                    if (Convert.ToInt32(dtgItens[0, i].Value) == relacao.codigo_indicador)
                    {
                        dtgItens[0, i].Selected = true;
                    }
                    if (limite)
                    {
                        for (int k = i; k < dtgItens.RowCount; k++)
                        {
                            if (Convert.ToInt32(dtgItens[0, k].Value) == relacao.codigo_indicador)
                            {
                                dtgItens[0, k].Selected = true;
                            }
                        }
                    }
                }
            }
            try
            {
                txtDescricao.Text = relacao.descricao;
                txtObervacao.Text = relacao.observacao;
                txtNome.Text = relacao.nome;
                txtId.Text = relacao.id.ToString();
            }
            catch
            { }
        }

        public RelacionarItemEIndicadorForm(ItemIndicador relacao)
        {

            this.relacao = relacao;
            InitializeComponent();
           // label1.Text = "Exibir Relacao";
            this.Text = "Exibir Relacao";
            ItemDao itemdao = new ItemDao();
            txtDescricao.Text = relacao.descricao;
            txtObervacao.Text = relacao.observacao;
            txtNome.Text = relacao.nome;
            txtId.Text = relacao.id.ToString();
            dtgItens.DataSource = itemdao.List();
            IndicadorDao indicadoresdao = new IndicadorDao();
            dtgIndicadores.DataSource = indicadoresdao.List();
            altera = false;
            exibir = true;

            for (int i = 0; i < dtgIndicadores.RowCount; i++)
            {
                if (Convert.ToInt32(dtgIndicadores[0, i].Value) == relacao.codigo_item)
                {
                    dtgIndicadores[0, i].Selected = true;
                }
                if (i < dtgItens.RowCount)
                {
                    if (Convert.ToInt32(dtgItens[0, i].Value) == relacao.codigo_indicador)
                    {
                        dtgItens[0, i].Selected = true;
                    }
                }
                if (i < dtgItens.RowCount)
                {
                    for (int k = i; k < dtgItens.RowCount; k++)
                    {
                        if (Convert.ToInt32(dtgItens[0, k].Value) == relacao.codigo_indicador)
                        {
                            dtgItens[0, k].Selected = true;
                        }
                    }
                }
            }
            try
            {
                txtDescricao.Text = relacao.descricao;
                txtObervacao.Text = relacao.observacao;
                txtNome.Text = relacao.nome;
                txtId.Text = relacao.id.ToString();
            }
            catch
            { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelacionarItemEIndicadorForm_Load(object sender, EventArgs e)
        {
            if (exibir)
            {
                txtNome.ReadOnly = true;
                txtObervacao.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                btnAdicionarRelacao.Visible = false;
                btnCancelar.Text = "Voltar";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!exibir)
            {
                ItemIndicador relacao_atual = new ItemIndicador();
                relacao_atual.descricao = txtDescricao.Text;
                relacao_atual.observacao = txtObervacao.Text;
                relacao_atual.nome = txtNome.Text;
                relacao_atual.codigo_indicador = Convert.ToInt32(dtgIndicadores[0, dtgIndicadores.CurrentRow.Index].Value);
                relacao_atual.codigo_item = Convert.ToInt32(dtgItens[0, dtgItens.CurrentRow.Index].Value);
                ItemIndicadorDao dao = new ItemIndicadorDao();
                LogDAO logdao = new LogDAO();
                if (relacao_atual.nome != string.Empty && relacao_atual.observacao != string.Empty &&
                   relacao_atual.descricao != string.Empty)
                {
                    if (!altera)
                    {
                        dao.inserir(relacao_atual);
                        logdao.inserir(user, "Relação Item Indicador Inserido nome="+relacao_atual.nome +", id user=" + user.id);
                        // INSERIR   
                    }
                    else
                    {
                        relacao_atual.id = Convert.ToInt32(txtId.Text);
                        dao.editar(relacao_atual);
                        logdao.inserir(user, "Relação Item Indicador Alterado nome=" + relacao_atual.nome + " id user=" + user.id);

                        relacao = null;
                        //ALTERAR
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos");
                }
    

            }
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

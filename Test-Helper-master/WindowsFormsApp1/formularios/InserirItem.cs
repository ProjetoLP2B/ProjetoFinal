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
    public partial class InserirItem : Form
    {
        Usuario user = null;
        bool altera = false, exibir = false;
        public InserirItem(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            altera = false;
            exibir = false;
        }

        public InserirItem(Item item, Usuario user)
        {
            this.user = user;
            InitializeComponent();
            altera = true;
            exibir = false;
            label1.Text = "Alterar Item";
            this.Text = "Alterar Item";
            try
            {
                txtIdItem.Text = Convert.ToString(item.id);
                txtNomeItem.Text = Convert.ToString(item.nome);
                txtObservacaoItem.Text = Convert.ToString(item.observacao);
                txtDescricaoItem.Text = Convert.ToString(item.descricao);
            }
            catch { }
        }

        public InserirItem(Item item)
        {
            InitializeComponent();
            altera = false;
            exibir = true;
            label1.Text = "Exibir Item";
            this.Text = "Exibir Item";
            try
            {
                txtIdItem.Text = Convert.ToString(item.id);
                txtNomeItem.Text = Convert.ToString(item.nome);
                txtObservacaoItem.Text = Convert.ToString(item.observacao);
                txtDescricaoItem.Text = Convert.ToString(item.descricao);
            }
            catch { }
        }


        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnConfirmarItem_Click(object sender, EventArgs e)
        {
            if (!exibir)
            {
                Item item = new Item();
                item.nome = txtNomeItem.Text;
                item.observacao = txtObservacaoItem.Text;
                item.descricao = txtDescricaoItem.Text;
                ItemDao itemdao = new ItemDao();
                LogDAO logdao = new LogDAO();
                if (item.nome != string.Empty && item.observacao != string.Empty &&
                    item.descricao != string.Empty)
                {
                    if (!altera)
                    {
                        itemdao.inserir(item);
                        logdao.inserir(user, "Item Inserido nome=" + item.nome + ", id user=" + user.id);
                    }
                    else
                    {
                        item.id = Convert.ToInt32(txtIdItem.Text);
                        itemdao.editar(item);
                        logdao.inserir(user, "Item Alterado,nome=" + item.nome + ",id user="+user.id);
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

        private void InserirItem_Load(object sender, EventArgs e)
        {

            if (exibir)
            {
                btnConfirmarItem.Visible = false;
                txtDescricaoItem.ReadOnly = true;
                txtObservacaoItem.ReadOnly = true;
                txtNomeItem.ReadOnly = true;
                btnCancelarItem.Text = "Voltar";
            }

        }
    }
}

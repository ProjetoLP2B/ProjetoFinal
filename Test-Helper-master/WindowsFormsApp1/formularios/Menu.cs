using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Usuario user = null;
        public static List<Indicador> lista_indicadores = null;
        public static List<ItemIndicador> lista_itemindicador = null;
        public static List<Item> lista_item = null;
        public static List<Log.Log> lista_log = null;
        public static List<RelacaoItemIndicador> lista_relacao = null;
        public static List<Usuario> lista_usuario = null;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            label1.Text = "Bem Vindo(a), "+user.nome.ToLower()+".";
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuarioform telausuario = new Usuarioform();
            telausuario.ShowDialog();
            
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Itemform telaitem = new Itemform(user);
            telaitem.ShowDialog();
        }

        private void btnIndicador_Click(object sender, EventArgs e)
        {
            Indicadorform telaindicador = new Indicadorform(user);
            telaindicador.ShowDialog();
        }

        private void btnMenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IndicadorDao dao = new IndicadorDao();
            Form1.lista_indicadores = dao.List();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnItemIndicador_Click(object sender, EventArgs e)
        {
            ItemIndicadorForm telaItemIndicador = new ItemIndicadorForm(user);
            telaItemIndicador.ShowDialog();
        }

        private void btnRelacaoItemIndicador_Click(object sender, EventArgs e)
        {
            RelacaoItemIndicadorForm telaRelacao = new RelacaoItemIndicadorForm(user);
            telaRelacao.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logar = new Login();
            logar.ShowDialog();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
             this.Hide();
            Login logar = new Login();
            logar.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Usuarioform telausuario = new Usuarioform();
            telausuario.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Itemform telaitem = new Itemform(user);
            telaitem.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Indicadorform telaindicador = new Indicadorform(user);
            telaindicador.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ItemIndicadorForm telaItemIndicador = new ItemIndicadorForm(user);
            telaItemIndicador.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RelacaoItemIndicadorForm telaRelacao = new RelacaoItemIndicadorForm(user);
            telaRelacao.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.formularios;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioDAO userdao = new UsuarioDAO();
            Usuario user = userdao.LogarUsuario(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                if (user.id > 0)
                {
                    this.Hide();
                    Form1 menu = new Form1(user);
                    menu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Dados de login incorretos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro telacad = new Cadastro();
            if (telacad.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Usuario Inserido com sucesso");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label(object sender, EventArgs e)
        {

        }
    }
}

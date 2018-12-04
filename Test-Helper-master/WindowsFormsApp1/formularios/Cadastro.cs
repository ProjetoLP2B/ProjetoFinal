using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.formularios
{
    public partial class Cadastro : Form
    {
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool EmailAlreadyExists(string email)
        {

            UsuarioDAO dao = new UsuarioDAO();
            Form1.lista_usuario = dao.EmailExists();

            foreach(var usuario in Form1.lista_usuario)
            {

                if(usuario.email == email)
                {
                    return false;
                }

            }


            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioDAO userdao = new UsuarioDAO();
            Usuario user = new Usuario();
            user.nome = textBox1.Text;
            user.sobrenome = textBox2.Text;
            user.email = textBox3.Text;
            user.senha = textBox4.Text;

            if (user.nome != string.Empty && 
                user.sobrenome != string.Empty && 
                user.senha != string.Empty)
            {
                if (IsValidEmail(textBox3.Text))
                {

                    if (EmailAlreadyExists(textBox3.Text))
                    {
                        userdao.inserir(user);
                        this.DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("Email \'" + textBox3.Text + "\' já cadastrado!");
                    }

                }
                else
                {

                    MessageBox.Show("Email invalido");
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

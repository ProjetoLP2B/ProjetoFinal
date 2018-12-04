using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class UsuarioDAO : DAO
    {
        MySqlCommand comando = null;
        public void inserir(Usuario usuario)
        {
            try
            {
                AbrirConexao();
                // CRIAR PRECEDURE PARA INSERIR USUARIOS
                comando = new MySqlCommand("call inserir_usuario(@nome,@sobrenome,@email,@senha);", conexao);
                comando.Parameters.AddWithValue("@nome", usuario.nome);
                comando.Parameters.AddWithValue("@sobrenome", usuario.sobrenome);
                comando.Parameters.AddWithValue("@email", usuario.email);
                comando.Parameters.AddWithValue("@senha", usuario.senha);

                if (comando.ExecuteNonQuery() > 0)
                    Console.WriteLine("INSERIDO COM SUCESSO");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Usuario> lista = new List<Usuario>();

        public List<Usuario> EmailExists()
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select * FROM Usuario";
                objDataTable = ExecutaConsultar(System.Data.CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.id = objLinha["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_Usuario"]) : 0;
                    usuario.nome = objLinha["Nome_Usuario"] != DBNull.Value ? Convert.ToString(objLinha["Nome_Usuario"]) : "";
                    usuario.sobrenome = objLinha["Sobrenome_Usuario"] != DBNull.Value ? Convert.ToString(objLinha["Sobrenome_Usuario"]) : "";
                    usuario.email = objLinha["Email_Usuario"] != DBNull.Value ? Convert.ToString(objLinha["Email_Usuario"]) : "";
                    usuario.senha = objLinha["Senha_Usuario"] != DBNull.Value ? Convert.ToString(objLinha["Senha_Usuario"]) : "";
                    lista.Add(usuario);
                }
                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Usuario> List()
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select  * from Usuario";
                objDataTable = ExecutaConsultar(System.Data.CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.id = objLinha["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_Usuario"]) : 0;
                    usuario.nome = objLinha["Nome_Usuario"] != DBNull.Value ? Convert.ToString(objLinha["Nome_Usuario"]) : "";
                    usuario.sobrenome = objLinha["Sobrenome_Usuario"] != DBNull.Value ? Convert.ToString(objLinha["Sobrenome_Usuario"]) : "";
                    usuario.email = objLinha["Email_Usuario"] != DBNull.Value ? Convert.ToString(objLinha["Email_Usuario"]) : "";
                    usuario.senha = objLinha["Senha_Usuario"] != DBNull.Value ? Convert.ToString(objLinha["Senha_Usuario"]) : "";
                    lista.Add(usuario);
                }
                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
            finally
            {
                FecharConexao();
            }
        }
        public void editar(Usuario usuario)
        {
            try
            {
                AbrirConexao();
                // CRIAR PRECEDURE PARA ATUALIZAR USUARIO
                comando = new MySqlCommand("call atualizar_usuario(@id,@nome,@sobrenome,@email,@senha);", conexao);
                comando.Parameters.AddWithValue("@id", usuario.id);
                comando.Parameters.AddWithValue("@nome", usuario.nome);
                comando.Parameters.AddWithValue("@sobrenome", usuario.sobrenome);
                comando.Parameters.AddWithValue("@email", usuario.email);
                comando.Parameters.AddWithValue("@senha", usuario.senha);

                if (comando.ExecuteNonQuery() > 0)
                    Console.WriteLine("ATUALIZADO COM SUCESSO");

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void exclui(Usuario user)
        {
            try
            {
                AbrirConexao();
                // CRIAR PRECEDURE PARA DELETAR USUARIO
                comando = new MySqlCommand("call delete_usuario(@userid);", conexao);
                comando.Parameters.AddWithValue("@userid", user.id);


                if (comando.ExecuteNonQuery() > 0)
                    Console.WriteLine("EXCLUIDO COM SUCESSO");

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public Usuario LogarUsuario(string email, string senha)
        {
            try
            {
                string query = "SELECT * FROM Usuario WHERE Email_Usuario='" + email + "' AND Senha_Usuario='" + senha + "';";
                DataTable consulta = ExecutaConsultar(CommandType.Text, query);
                if (consulta.Rows.Count <= 0)
                {
                    return null;
                }
                if (consulta.Rows.Count > 1)
                {
                    return null;
                }
                if (consulta.Rows.Count == 1)
                {
                    DataRow linha_id = consulta.Rows[0];
                    Usuario user = new Usuario();
                    user.id = linha_id["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(linha_id["Id_Usuario"]) : 0;
                    user.nome = linha_id["Nome_Usuario"] != DBNull.Value ? Convert.ToString(linha_id["Nome_Usuario"]) : "";
                    user.sobrenome = linha_id["Sobrenome_Usuario"] != DBNull.Value ? Convert.ToString(linha_id["Sobrenome_Usuario"]) : "";
                    user.email = linha_id["Email_Usuario"] != DBNull.Value ? Convert.ToString(linha_id["Email_Usuario"]) : "";
                    user.senha = linha_id["Senha_Usuario"] != DBNull.Value ? Convert.ToString(linha_id["Senha_Usuario"]) : "";
                    return user;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

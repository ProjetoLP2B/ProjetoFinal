using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Log
{
    public class LogDAO : DAO
    {
        MySqlCommand comando = null;
        public void inserir(Usuario user, string descricao)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call inserir_log(@Id_User,@Data_Alteracao,@Descricao_Registro);", conexao);
                comando.Parameters.AddWithValue("@Id_User", user.id);
                comando.Parameters.AddWithValue("@Data_Alteracao", DateTime.Now);
                comando.Parameters.AddWithValue("@Descricao_Registro", descricao);

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
        public List<Log> lista = new List<Log>();

        public List<Log> List()
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select  * from Log";
                objDataTable = ExecutaConsultar(System.Data.CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Log item = new Log();
                    try
                    {
                        item.id = objLinha["id_log"] != DBNull.Value ? Convert.ToInt32(objLinha["id_log"]) : 0;
                        item.id_user = objLinha["Id_User"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_User"]) : 0;
                        item.date = Convert.ToDateTime(objLinha["Data_Alteracao"]);
                        item.descricao = objLinha["Descricao_Registro"] != DBNull.Value ? Convert.ToString(objLinha["Descricao_Registro"]) : "";
                        lista.Add(item);
                    }
                    catch
                    {
                    }
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

        public List<Log> Pesquisar(string query)
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = query;
                objDataTable = ExecutaConsultar(System.Data.CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Log item = new Log();
                    try
                    {
                        item.id = objLinha["id_log"] != DBNull.Value ? Convert.ToInt32(objLinha["id_log"]) : 0;
                        item.id_user = objLinha["Id_User"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_User"]) : 0;
                        item.date = Convert.ToDateTime(objLinha["Data_Alteracao"]);
                        item.descricao = objLinha["Descricao_Registro"] != DBNull.Value ? Convert.ToString(objLinha["Descricao_Registro"]) : "";
                        lista.Add(item);
                    }
                    catch
                    {
                    }
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
    }
}

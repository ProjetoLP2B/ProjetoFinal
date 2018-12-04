using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DAO : Conexao
    {
        private static MySqlParameterCollection objParametros = new MySqlCommand().Parameters;
        public static void LimparParametros()
        {
            objParametros.Clear();
        }
        public static void AdicionarParametros(string strNomeParametro, object objValor)
        {
            objParametros.Add(new MySqlParameter(strNomeParametro, objValor));
        }

        public DataTable ExecutaConsultar(CommandType objTipo, string strSql)
        {
            try
            {
                AbrirConexao();
                MySqlCommand objComando = conexao.CreateCommand();
                objComando.CommandType = objTipo;
                objComando.CommandText = strSql;
                objComando.CommandTimeout = 60;
                foreach (MySqlParameter objParametro in objParametros)
                    objComando.Parameters.Add(new MySqlParameter(objParametro.ParameterName, objParametro.Value));
                MySqlDataAdapter objAdaptador = new MySqlDataAdapter(objComando);
                DataTable objTabelaRecebeDados = new DataTable();
                objAdaptador.Fill(objTabelaRecebeDados);
                return objTabelaRecebeDados;
            }
            catch (Exception objErro)
            {
                throw new Exception(objErro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}

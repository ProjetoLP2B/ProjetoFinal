using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp1
{
    public class IndicadorDao : DAO
    {
        MySqlCommand comando = null;
        public void inserir(Indicador indicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call INSERIR_INDICADOR(@nome,@descricao,@observacao);", conexao);
                comando.Parameters.AddWithValue("@nome", indicador.nome);
                comando.Parameters.AddWithValue("@descricao", indicador.descricao);
                comando.Parameters.AddWithValue("@observacao", indicador.observacao);

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

        public List<Indicador> lista = new List<Indicador>();

        public List<Indicador> List()
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select  * from Indicador";

                objDataTable = ExecutaConsultar(CommandType.Text, strSQL);

                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Indicador indicador = new Indicador();
                    indicador.id = objLinha["Id_Indicador"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_Indicador"]) : 0;
                    indicador.nome = objLinha["Nome_Indicador"] != DBNull.Value ? Convert.ToString(objLinha["Nome_Indicador"]) : "";
                    indicador.descricao = objLinha["Descricao_Indicador"] != DBNull.Value ? Convert.ToString(objLinha["Descricao_Indicador"]) : "";
                    indicador.observacao = objLinha["Observacao_Indicador"] != DBNull.Value ? Convert.ToString(objLinha["Observacao_Indicador"]) : "";
                    lista.Add(indicador);
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
        public void editar (Indicador indicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call atualizar_indicador(@id,@nome,@descricao,@observacao);", conexao);
                comando.Parameters.AddWithValue("@id", indicador.id);
                comando.Parameters.AddWithValue("@nome", indicador.nome);
                comando.Parameters.AddWithValue("@descricao", indicador.descricao);
                comando.Parameters.AddWithValue("@observacao", indicador.observacao);

                if (comando.ExecuteNonQuery() > 0)
                    Console.WriteLine("ATUALIZADO COM SUCESSO");

            }
            catch( Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void exclui(Indicador indicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call delete_indicador(@indicadorid);", conexao);
                comando.Parameters.AddWithValue("@indicadorid", indicador.id);


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
        public List<Indicador> Pesquisar(string query)
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = query;

                objDataTable = ExecutaConsultar(CommandType.Text, strSQL);

                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Indicador indicador = new Indicador();
                    indicador.id = objLinha["Id_Indicador"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_Indicador"]) : 0;
                    indicador.nome = objLinha["Nome_Indicador"] != DBNull.Value ? Convert.ToString(objLinha["Nome_Indicador"]) : "";
                    indicador.descricao = objLinha["Descricao_Indicador"] != DBNull.Value ? Convert.ToString(objLinha["Descricao_Indicador"]) : "";
                    indicador.observacao = objLinha["Observacao_Indicador"] != DBNull.Value ? Convert.ToString(objLinha["Observacao_Indicador"]) : "";
                    lista.Add(indicador);
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
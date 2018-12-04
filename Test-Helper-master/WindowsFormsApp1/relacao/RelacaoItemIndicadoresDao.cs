using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RelacaoItemIndicadoresDao : DAO
    {
        MySqlCommand comando = null;
        public void inserir(RelacaoItemIndicador relacaoItemIndicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call inserir_Relacao_Item_Indicador(@nome, @cod1, @cod2, @descricao, @observacao);", conexao);
                comando.Parameters.AddWithValue("@nome", relacaoItemIndicador.nome);
                comando.Parameters.AddWithValue("@cod1", relacaoItemIndicador.cod1);
                comando.Parameters.AddWithValue("@cod2", relacaoItemIndicador.cod2);
                comando.Parameters.AddWithValue("@descricao", relacaoItemIndicador.descricao);
                comando.Parameters.AddWithValue("@observacao", relacaoItemIndicador.observacao);

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
        public List<RelacaoItemIndicador> lista = new List<RelacaoItemIndicador>();

        public List<RelacaoItemIndicador> List()
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select  * from Relacao_Item_Indicador";
                objDataTable = ExecutaConsultar(System.Data.CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    RelacaoItemIndicador relacaoItemIndicador = new RelacaoItemIndicador();
                    relacaoItemIndicador.id = objLinha["Id_Relacao_Item_Indicador"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_Relacao_Item_Indicador"]) : 0;
                    relacaoItemIndicador.nome = objLinha["Nome_Relacao_ItemIndicador"] != DBNull.Value ? Convert.ToString(objLinha["Nome_Relacao_ItemIndicador"]) : "";
                    relacaoItemIndicador.cod1 = objLinha["Codigo1_ItemIndicador"] != DBNull.Value ? Convert.ToInt32(objLinha["Codigo1_ItemIndicador"]) : 0;
                    relacaoItemIndicador.cod2 = objLinha["Codigo2_ItemIndicador"] != DBNull.Value ? Convert.ToInt32(objLinha["Codigo2_ItemIndicador"]) : 0;
                    relacaoItemIndicador.descricao = objLinha["Descricao_Relacao_ItemIndicador"] != DBNull.Value ? Convert.ToString(objLinha["Descricao_Relacao_ItemIndicador"]) : "";
                    relacaoItemIndicador.observacao = objLinha["Observacao_Relacao_ItemIndicador"] != DBNull.Value ? Convert.ToString(objLinha["Observacao_Relacao_ItemIndicador"]) : "";
                    lista.Add(relacaoItemIndicador);
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

        public void editar(RelacaoItemIndicador relacaoItemIndicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call atualizar_Relacao_Item_Indicador(@id,@nome, @cod1, @cod2, @descricao,@observacao);", conexao);
                comando.Parameters.AddWithValue("@id", relacaoItemIndicador.id);
                comando.Parameters.AddWithValue("@nome", relacaoItemIndicador.nome);
                comando.Parameters.AddWithValue("@cod1", relacaoItemIndicador.cod1);
                comando.Parameters.AddWithValue("@cod2", relacaoItemIndicador.cod2);
                comando.Parameters.AddWithValue("@descricao", relacaoItemIndicador.descricao);
                comando.Parameters.AddWithValue("@observacao", relacaoItemIndicador.observacao);

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

        public void exclui(RelacaoItemIndicador relacaoItemIndicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call delete_relacao_item_indicador(@id);", conexao);
                comando.Parameters.AddWithValue("@id", relacaoItemIndicador.id);
  
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
        public List<RelacaoItemIndicador> Pesquisar(string query)
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
                    RelacaoItemIndicador relacaoItemIndicador = new RelacaoItemIndicador();
                    relacaoItemIndicador.id = objLinha["Id_Relacao_Item_Indicador"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_Relacao_Item_Indicador"]) : 0;
                    relacaoItemIndicador.nome = objLinha["Nome_Relacao_ItemIndicador"] != DBNull.Value ? Convert.ToString(objLinha["Nome_Relacao_ItemIndicador"]) : "";
                    relacaoItemIndicador.cod1 = objLinha["Codigo1_ItemIndicador"] != DBNull.Value ? Convert.ToInt32(objLinha["Codigo1_ItemIndicador"]) : 0;
                    relacaoItemIndicador.cod2 = objLinha["Codigo2_ItemIndicador"] != DBNull.Value ? Convert.ToInt32(objLinha["Codigo2_ItemIndicador"]) : 0;
                    relacaoItemIndicador.descricao = objLinha["Descricao_Relacao_ItemIndicador"] != DBNull.Value ? Convert.ToString(objLinha["Descricao_Relacao_ItemIndicador"]) : "";
                    relacaoItemIndicador.observacao = objLinha["Observacao_Relacao_ItemIndicador"] != DBNull.Value ? Convert.ToString(objLinha["Observacao_Relacao_ItemIndicador"]) : "";
                    lista.Add(relacaoItemIndicador);
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

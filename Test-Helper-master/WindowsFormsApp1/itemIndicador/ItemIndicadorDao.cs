using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ItemIndicadorDao : DAO
    {
        MySqlCommand comando = null;
        public void inserir(ItemIndicador itemIndicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call inserir_item_indicador(@Nome_ItemIndicador,@Codigo_Item,@Codigo_Indicador,@Descricao_ItemIndicador,@Observacao_ItemIndicador);", conexao);
                comando.Parameters.AddWithValue("@Nome_ItemIndicador", itemIndicador.nome);
                comando.Parameters.AddWithValue("@Codigo_Item", itemIndicador.codigo_item);
                comando.Parameters.AddWithValue("@Codigo_Indicador", itemIndicador.codigo_indicador);
                comando.Parameters.AddWithValue("@Descricao_ItemIndicador", itemIndicador.descricao);
                comando.Parameters.AddWithValue("@Observacao_ItemIndicador", itemIndicador.observacao);

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
        public List<ItemIndicador> lista = new List<ItemIndicador>();

        public List<ItemIndicador> List()
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select  * from Item_Indicador";
                objDataTable = ExecutaConsultar(System.Data.CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    ItemIndicador itemIndicador = new ItemIndicador();
                    itemIndicador.id = objLinha["id_itemindicador"] != DBNull.Value ? Convert.ToInt32(objLinha["id_itemindicador"]) : 0;
                    itemIndicador.nome = objLinha["nome_itemindicador"] != DBNull.Value ? Convert.ToString(objLinha["nome_itemindicador"]) : "";
                    itemIndicador.codigo_item = objLinha["codigo_item"] != DBNull.Value ? Convert.ToInt32(objLinha["codigo_item"]) : 0;
                    itemIndicador.codigo_indicador = objLinha["codigo_indicador"] != DBNull.Value ? Convert.ToInt32(objLinha["codigo_indicador"]) : 0;
                    itemIndicador.descricao = objLinha["descricao_itemindicador"] != DBNull.Value ? Convert.ToString(objLinha["descricao_itemindicador"]) : "";
                    itemIndicador.observacao = objLinha["observacao_itemindicador"] != DBNull.Value ? Convert.ToString(objLinha["observacao_itemindicador"]) : "";
                    lista.Add(itemIndicador);
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

        public void editar(ItemIndicador itemIndicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call atualizar_item_indicador(@id,@nome,@cod_item,@cod_indica,@descricao,@observacao);", conexao);
                comando.Parameters.AddWithValue("@id", itemIndicador.id);
                comando.Parameters.AddWithValue("@nome", itemIndicador.nome);
                comando.Parameters.AddWithValue("@cod_item", itemIndicador.codigo_item);
                comando.Parameters.AddWithValue("@cod_indica", itemIndicador.codigo_indicador);
                comando.Parameters.AddWithValue("@descricao", itemIndicador.descricao);
                comando.Parameters.AddWithValue("@observacao", itemIndicador.observacao);

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

        public void exclui(ItemIndicador itemIndicador)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call delete_item_indicador(@itemindicadorid);", conexao);
                comando.Parameters.AddWithValue("@itemindicadorid", itemIndicador.id);


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
        public List<ItemIndicador> Pesquisar(string query)
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
                    ItemIndicador itemIndicador = new ItemIndicador();
                    itemIndicador.id = objLinha["id_itemindicador"] != DBNull.Value ? Convert.ToInt32(objLinha["id_itemindicador"]) : 0;
                    itemIndicador.nome = objLinha["nome_itemindicador"] != DBNull.Value ? Convert.ToString(objLinha["nome_itemindicador"]) : "";
                    itemIndicador.codigo_item = objLinha["codigo_item"] != DBNull.Value ? Convert.ToInt32(objLinha["codigo_item"]) : 0;
                    itemIndicador.codigo_indicador = objLinha["codigo_indicador"] != DBNull.Value ? Convert.ToInt32(objLinha["codigo_indicador"]) : 0;
                    itemIndicador.descricao = objLinha["descricao_itemindicador"] != DBNull.Value ? Convert.ToString(objLinha["descricao_itemindicador"]) : "";
                    itemIndicador.observacao = objLinha["observacao_itemindicador"] != DBNull.Value ? Convert.ToString(objLinha["observacao_itemindicador"]) : "";
                    lista.Add(itemIndicador);
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

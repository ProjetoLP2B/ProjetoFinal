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
    public class ItemDao:DAO
    {
        MySqlCommand comando = null;
        public void inserir(Item item)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call INSERIR_ITEM(@nome,@descricao,@observacao);", conexao);
                comando.Parameters.AddWithValue("@nome", item.nome);
                comando.Parameters.AddWithValue("@descricao", item.descricao);
                comando.Parameters.AddWithValue("@observacao", item.observacao);

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
        public List<Item> lista = new List<Item>();

        public List<Item> List()
        {
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select  * from Item";
                objDataTable = ExecutaConsultar(System.Data.CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Item item = new Item();
                    item.id = objLinha["id_item"] != DBNull.Value ? Convert.ToInt32(objLinha["id_item"]) : 0;
                    item.nome = objLinha["nome_item"] != DBNull.Value ? Convert.ToString(objLinha["nome_item"]) : "";
                    item.descricao = objLinha["descricao_item"] != DBNull.Value ? Convert.ToString(objLinha["descricao_item"]) : "";
                    item.observacao = objLinha["observacao_item"] != DBNull.Value ? Convert.ToString(objLinha["observacao_item"]) : "";
                    lista.Add(item);
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

        public void editar(Item item)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call atualizar_item(@id,@nome,@descricao,@observacao);", conexao);
                comando.Parameters.AddWithValue("@id", item.id);
                comando.Parameters.AddWithValue("@nome", item.nome);
                comando.Parameters.AddWithValue("@descricao", item.descricao);
                comando.Parameters.AddWithValue("@observacao", item.observacao);

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

        public void exclui(Item item)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("call delete_item(@itemid);", conexao);
                comando.Parameters.AddWithValue("@itemid", item.id);


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
        public List<Item> Pesquisar(string query)
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
                    Item item = new Item();
                    item.id = objLinha["id_item"] != DBNull.Value ? Convert.ToInt32(objLinha["id_item"]) : 0;
                    item.nome = objLinha["nome_item"] != DBNull.Value ? Convert.ToString(objLinha["nome_item"]) : "";
                    item.descricao = objLinha["descricao_item"] != DBNull.Value ? Convert.ToString(objLinha["descricao_item"]) : "";
                    item.observacao = objLinha["observacao_item"] != DBNull.Value ? Convert.ToString(objLinha["observacao_item"]) : "";
                    lista.Add(item);
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

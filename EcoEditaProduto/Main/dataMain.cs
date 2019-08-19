using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Windows.Forms;

namespace EcoEditaProduto.Main
{
    class dataMain
    {
        static FbConnection conexao = null;
        static string server = Properties.Settings.Default.Conexao;

        public modelInformacoes BuscaInformacoes(string codigo)
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                modelInformacoes model = new modelInformacoes();
                string query =
                    "select                                                   " +
                    "pdg.descricao,                                           " +
                    "pdg.observacao,                                          " +
                    "pdg.composicao,                                          " +
                    "pdg.aplicacao,                                           " +
                    "pdg.referencia,                                          " +
                    "est.endereco                                             " +
                    "														  " +
                    "from testprodutogeral pdg                                " +
                    "inner join testestoque est on (pdg.codigo = est.produto) " +
                    "where cast(pdg.codigo as int) = @codigo                  ";
                FbCommand cmd = new FbCommand(query, conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model.descricao = reader["descricao"].ToString();
                    model.observacao = reader["observacao"].ToString();
                    model.composicao = reader["composicao"].ToString();
                    model.aplicacao = reader["aplicacao"].ToString();
                    model.referencia = reader["referencia"].ToString();
                    model.endereco = reader["endereco"].ToString();
                }
                return model;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexao.Close();
            }     
        }

        public static void SalvarInformacoes(modelInformacoes model)
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                string query =
                    "UPDATE testprodutoGERAL A SET          " +
                    "								        " +
                    "A.observacao = @OBSERVACAO,            " +
                    "A.composicao = @COMPOSICAO,            " +
                    "A.aplicacao = @APLICACAO,              " +
                    "A.referencia = @REFERENCIA             " +
                    "WHERE                                  " +
                    "A.codigo = @CODIGO;                    ";
                   // "								        " +
                   // "UPDATE testestoque B SET               " +
                   // "B.endereco = @ENDERECO                 " +
                   // "WHERE                                  " +
                   // "B.empresa = @EMPRESA                   " +
                   // "AND B.produto = @PRODUTO;commit work;  " ;
                FbCommand cmd = new FbCommand(query, conexao);
                cmd.Parameters.AddWithValue("@OBSERVACAO",model.observacao);
                cmd.Parameters.AddWithValue("@COMPOSICAO", model.composicao);
                cmd.Parameters.AddWithValue("@APLICACAO", model.aplicacao);
                cmd.Parameters.AddWithValue("@REFERENCIA", model.referencia);
                cmd.Parameters.AddWithValue("@CODIGO", model.codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

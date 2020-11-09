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

        public modelInformacoes BuscaInformacoes(string codigo, string empresa, string almoxarifado)
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                modelInformacoes model = new modelInformacoes();
                string query =
                         "select                                                    " +
                         "pdg.descricao,                                            " +
                         "pdg.observacao,                                           " +
                         "pdg.composicao,                                           " +
                         "pdg.aplicacao,                                            " +
                         "pdg.referencia,                                           " +
                         "pdg.codigofabrica,                                        " +
                         "est.endereco                                              " +
                         "                                                          " +
                         "from testprodutogeral pdg                                 " +
                         "inner join testestoque est on (pdg.codigo = est.produto)  " +
                         "where                                                     " +
                         "cast(pdg.codigo as int) = @codigo                         " +
                         "and est.empresa = @empresa                                " +
                         "and est.almox = @almoxarifado                             ";

                FbCommand cmd = new FbCommand(query, conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@empresa", empresa);
                cmd.Parameters.AddWithValue("@almoxarifado", almoxarifado);
                FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model.descricao = reader["descricao"].ToString();
                    model.observacao = reader["observacao"].ToString();
                    model.composicao = reader["composicao"].ToString();
                    model.aplicacao = reader["aplicacao"].ToString();
                    model.referencia = reader["referencia"].ToString();
                    model.endereco = reader["endereco"].ToString();
                    model.codFabrica = reader["codigofabrica"].ToString();
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

        public static void BuscaEmpresa(ComboBox cbx)
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                string query = "select a.codigo ||'-'||a.razaosocial as empresa from tgerempresa a order by 1 asc";
                FbCommand cmd = new FbCommand(query, conexao);
                FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbx.Items.Add(reader["empresa"].ToString());
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }

        }

        public static void BuscaAlmox(ComboBox cbx, string idEmpresa)
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                string query = "select a.codigo ||'-'||a.descricao as almoxarifado from testalmox a where a.empresa = @empresa order by 1 asc";
                FbCommand cmd = new FbCommand(query, conexao);
                cmd.Parameters.AddWithValue("@empresa", idEmpresa);
                FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbx.Items.Add(reader["ALMOXARIFADO"].ToString());
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void SalvarInformacoes(modelInformacoes model, string empresa, string almoxarifado)
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();

                void updGeral()
                {
                    string query1 =
                       "UPDATE testprodutoGERAL A SET          " +
                       "A.observacao = @OBSERVACAO,            " +
                       "A.composicao = @COMPOSICAO,            " +
                       "A.aplicacao = @APLICACAO,              " +
                       "A.codigofabrica = @CODFABRICA,         " +
                       "A.referencia = @REFERENCIA             " +
                       "WHERE                                  " +
                       "cast(A.codigo as int) = @CODIGO;       ";
                    FbCommand cmd = new FbCommand(query1, conexao);
                    cmd.Parameters.AddWithValue("@OBSERVACAO", model.observacao);
                    cmd.Parameters.AddWithValue("@COMPOSICAO", model.composicao);
                    cmd.Parameters.AddWithValue("@APLICACAO", model.aplicacao);
                    cmd.Parameters.AddWithValue("@REFERENCIA", model.referencia);
                    cmd.Parameters.AddWithValue("@CODIGO", model.codigo);
                    cmd.Parameters.AddWithValue("@ENDERECO", model.endereco);
                    cmd.Parameters.AddWithValue("@CODFABRICA", model.codFabrica);
                    cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                    cmd.Parameters.AddWithValue("@ALMOXARIFADO", almoxarifado);
                    cmd.ExecuteNonQuery();
                }

                void updEndereco()
                {
                    string query2 =
                      "UPDATE testestoque B SET                  " +
                      "B.endereco = @ENDERECO                    " +
                      "WHERE                                     " +
                      "cast(B.empresa as int) = @EMPRESA         " +
                      "AND cast(B.produto as int) = @CODIGO      " +
                      "and cast(b.almox as int) = @ALMOXARIFADO  ";
                    FbCommand cmd2 = new FbCommand(query2, conexao);
                    cmd2.Parameters.AddWithValue("@CODIGO", model.codigo);
                    cmd2.Parameters.AddWithValue("@ENDERECO", model.endereco);
                    cmd2.Parameters.AddWithValue("@EMPRESA", empresa);
                    cmd2.Parameters.AddWithValue("@ALMOXARIFADO", almoxarifado);
                    cmd2.ExecuteNonQuery();
                }

                updGeral();
                updEndereco();
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

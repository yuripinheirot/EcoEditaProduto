using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Windows.Forms;

namespace EcoEditaProduto.PesquisarProduto
{
    class dataProduto
    {
        static FbConnection conexao = null;
        static string server = Properties.Settings.Default.Conexao;

        public static void AtualizaDgv(DataGridView dgv, string Inativo)
        {
            try
            {
                conexao = new FbConnection(server);
                conexao.Open();
                string query =
                "select                                                                                " +
                "																					   " +
                "pdt.produto,                                                                          " +
                "pdg.descricao,                                                                        " +
                "pdg.embalagem,                                                                        " +
                "mrc.descricao as Marca,                                                               " +
                "grp.descricao as Grupo,                                                               " +
                "sgp.descricao as SubGrupo,                                                            " +
                "pdg.referencia,                                                                       " +
                "pdt.prpraticado as PrecoPraticado,                                                    " +
                "pdt.ativo                                                                             " +
                "																					   " +
                "from testproduto pdt                                                                  " +
                "inner join testprodutogeral pdg on (pdt.produto = pdg.codigo)                         " +
                "inner join testmarca mrc on (pdg.marca = mrc.codigo)                                  " +
                "inner join testgrupo grp on (pdt.grupo = grp.codigo and pdt.empresa = grp.empresa)    " +
                "inner join testsubgrupo sgp on (sgp.grupo = grp.codigo and sgp.empresa = grp.empresa) " +
                "where " + Inativo + " ;";//and " + PesquisarPor + " like upper('%" + PalavraChave + "%');  ";
                FbCommand cmd = new FbCommand(query, conexao);
                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                dgv.DataSource = table;
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
    }
}

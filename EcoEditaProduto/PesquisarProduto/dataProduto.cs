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
        FbConnection conexao = null;
        string server = Properties.Settings.Default.Conexao;

        public void AtualizaDgv(DataGridView dgv)
        {
            try
            {
                conexao = new FbConnection(server);
                string query = 
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}

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

        public modelInformacoes BuscaInformcoes(string codigo)
        {
            try
            {
                conexao = new FbConnection(server);
                string query = ""
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

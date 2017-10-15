using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondS.PIM.DataAccess
{
    public class configuracaoDA
    {
        public string LeStringConexao(string Chave)
        {
            string strConexao = "Data Source = DESKTOP - 4GM59OE\\SQLEXPRESS; Initial Catalog = dbDesafio; Integrated Security = True";

            try
            {
                strConexao = System.Configuration.ConfigurationManager.ConnectionStrings[Chave].ConnectionString;
            }
            catch
            {
                strConexao = string.Empty;
            }

            return strConexao;
        }
    }
}

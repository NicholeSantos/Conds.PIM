using System;
using System.Data.SqlClient;

namespace CondS.PIM.DataAccess
{
    public class dbCond
    {
        string stringDeConexao = @"Data Source=DESKTOP-4GM59OE\SQLEXPRESS;Initial Catalog=dbCond;Integrated Security=True";
        #region[Passando para o banco]
        public bool MedotoNaoQuery(string QuerySQL)
        {
            bool retorno = false;
            SqlConnection conexao = null;
            SqlCommand comando = null;
            try
            {
                //Cria conexão com banco de dados
                conexao = new SqlConnection(stringDeConexao);
                //PREPARA A QUERY A SER EXECUTADA NO BANCO
                comando = new SqlCommand(QuerySQL, conexao);
                //ABRIR CONEXAO
                conexao.Open();
                //EXECUTAR QUERY NO BANCO
                comando.ExecuteNonQuery();
                //SE CHEGOU AQUI E QUE O COMANDO FOI EXECUTADO COM SUCESSO
                retorno = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
                retorno = false;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }

            return retorno;
        }

        #endregion

    }
}

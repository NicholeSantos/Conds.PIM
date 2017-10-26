using CondS.PIM.Modelo;
using System;

namespace CondS.PIM.DataAccess.dbEntidades
{
    public class dbUsuario
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCadastro { get; set; }

        //---------------------------------------------

        public void Cadastrar(usuarioMOD dadosDaTela)
        {
            string QuerySQL = string.Empty;

            try
            {
                dbCond banco01 = new dbCond();
                 QuerySQL = "INSERT INTO tbUsuario(usuario, senha, tipo) VALUES(" + "'" + dadosDaTela.Usuario + "'" +","+"'"+dadosDaTela.Senha+"'"+","+"'"+dadosDaTela.Tipo+"'"+ ") ";
                banco01.MedotoNaoQuery(QuerySQL);

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                err += " !!!";
                //FUTURO LOG DA APLICAÇÃO
            }

        }
    }
}

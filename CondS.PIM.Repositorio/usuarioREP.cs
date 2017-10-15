using CondS.PIM.DataAccess.dbEntidades;
using CondS.PIM.Modelo;

namespace CondS.PIM.Repositorio
{
    public class usuarioREP
    {

        public void Cadastrar(usuarioMOD dadosDaTela)
        {
            dbUsuario usuario = new dbUsuario();
            usuario.Cadastrar(dadosDaTela);
       

        }
    }
}

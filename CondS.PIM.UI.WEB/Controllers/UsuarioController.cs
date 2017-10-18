using CondS.PIM.Modelo;
using CondS.PIM.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CondS.PIM.UI.WEB.Controllers
{
    public class UsuarioController : Controller
    {
        //Instanciando repositorio
        usuarioREP usuarioREP = new usuarioREP();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        //Quando for postar, passar para o modelo 
        public ActionResult Cadastrar(usuarioMOD dadosDaTela)
        {
            usuarioREP.Cadastrar(dadosDaTela);
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}
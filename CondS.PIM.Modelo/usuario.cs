using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondS.PIM.Modelo
{
    public class usuario
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}

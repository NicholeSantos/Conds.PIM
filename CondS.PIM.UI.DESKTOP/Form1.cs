using CondS.PIM.Modelo;
using CondS.PIM.Repositorio;
using System;
using System.Windows.Forms;

namespace CondS.PIM.UI.DESKTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioMOD usuarioMOD = new usuarioMOD();
            usuarioMOD.Usuario = "TEST DESKTOP";
            usuarioMOD.Senha = "TESTE DESKTOP";
            usuarioMOD.Tipo = "TestewINICUS";
            usuarioREP usuarioREP = new usuarioREP();
            usuarioREP.Cadastrar(usuarioMOD);


        }
    }
}

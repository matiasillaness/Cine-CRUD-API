using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class Cuenta
    {
        public string usuario { get; set; }
        public string contrasenia { get; set; }

        public Cuenta(string usuario, string contrasenia)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }

       public Cuenta()
        {
            this.usuario = "";
            this.contrasenia = "";
        }

    }
}

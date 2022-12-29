using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class Usuario
    {

        public string nombre { get; set; }
        public string contra { get; set; }




        public Usuario()
        {
            nombre = contra = "";
        }

        public Usuario(string contra, string nombres)
        {
            this.nombre = nombres;
            this.contra = contra;
        }

        public string pnombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string pcontraseña
        {
            set { contra = value; }
            get { return contra; }
        }

        override public string ToString()
        {
            return contra + ", " + nombre;
        }
    }
}

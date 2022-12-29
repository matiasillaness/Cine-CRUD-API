using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class FuncionComplementaria
    {
        public int id_funcion{ get; set; }

        public string Display { get; set; }


        public FuncionComplementaria(int id_funcion, string display)
        {
            this.id_funcion = id_funcion;
            Display = display;
        }
        public FuncionComplementaria()
        {
            id_funcion = 0;
            Display = string.Empty;
        }
    }
}

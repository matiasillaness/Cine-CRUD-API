using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }
        public string Email { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public long Telefono { get; set; }

        public Cliente(int id_cliente, string nombre, string apellido, long dni, string email, string calle, int altura, long telefono)
        {
            Id_Cliente = id_cliente;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Email = email;
            Calle = calle;
            Altura = altura;
            Telefono = telefono;
        }

        public Cliente()
        {
            Id_Cliente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Dni = 0;
            Email = string.Empty;
            Calle = string.Empty;
            Altura = 0;
            Telefono = 0;
        }
    }
}

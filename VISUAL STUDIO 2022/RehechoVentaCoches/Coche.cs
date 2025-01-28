using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehechoVentaCoches
{
    internal class Coche
    {
        public string Nombre { get; }
        public int Precio { get; }

        public Coche(string nombre, int precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }
    }
}
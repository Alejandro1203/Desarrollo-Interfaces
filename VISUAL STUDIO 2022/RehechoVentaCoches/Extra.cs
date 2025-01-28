using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehechoVentaCoches
{
    internal class Extra
    {
        public string Nombre { get; }
        public int Precio { get; }

        public Extra(string nombre, int precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInforme_4
{
    public class Ciudad
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int Population { get; set; }
        public string Timezone { get; set; }

        public Ciudad()
        {
        }
    }
}
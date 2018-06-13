using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Critica
    {
        public string nombre_emisor { get; set; }
        public string mensaje { get; set; }

        public Critica(string nombre_emisor, string mensaje)
        {
            this.nombre_emisor = nombre_emisor;
            this.mensaje = mensaje;
        }
    }
}

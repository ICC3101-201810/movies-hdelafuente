using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Estudio
    {
        public string nombre;
        string direccion;
        DateTime fecha_apertura;

        public Estudio(string nombre, string direccion, DateTime fecha_apertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fecha_apertura = fecha_apertura;
        }
    }
}

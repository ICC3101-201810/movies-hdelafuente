using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    public class Pelicula
    {
        public string nombre;
        Persona director;
        DateTime fecha_estreno;
        string descripcion;
        int presupuesto;
        Estudio estudio;

        public Pelicula(string nombre, Persona director, DateTime fecha_estreno, string descripcion, int presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fecha_estreno = fecha_estreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
    }
}

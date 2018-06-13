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
        public Persona director;
        public DateTime fecha_estreno;
        public string descripcion;
        public int presupuesto;
        public Estudio estudio;
        public List<Critica> criticas = new List<Critica>();
        public Pelicula(string nombre, Persona director, DateTime fecha_estreno, string descripcion, int presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fecha_estreno = fecha_estreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
        public static void RecibeCritica(string nombre_emisor, string mensaje, Pelicula pelicula)
        {
            Critica a = new Critica(nombre_emisor, mensaje);
            pelicula.criticas.Add(a);
        }
    }
}

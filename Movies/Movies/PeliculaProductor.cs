using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    public class PeliculaProductor
    {
        Productor productor;
        Pelicula pelicula;
        public PeliculaProductor(Productor productor, Pelicula pelicula)
        {
            this.productor = productor;
            this.pelicula = pelicula;
        }
    }
}

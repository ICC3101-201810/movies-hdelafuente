using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    public class PeliculaActor
    {
        Actor actor;
        Pelicula pelicula;
        public PeliculaActor(Actor actor, Pelicula pelicula)
        {
            this.actor = actor;
            this.pelicula = pelicula;
        }
    }
}

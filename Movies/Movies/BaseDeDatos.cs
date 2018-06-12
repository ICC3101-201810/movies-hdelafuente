using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    class BaseDeDatos
    {
        public List<Pelicula> peliculas = new List<Pelicula>();
        public List<Director> directores = new List<Director>();
        public List<Actor> actores= new List<Actor>();
        public List<Productor> productores = new List<Productor>();
        public List<Estudio> estudios = new List<Estudio>();
        public List<PeliculaActor> PeliculaActors = new List<PeliculaActor>();
        public List<PeliculaProductor> PeliculaProductors = new List<PeliculaProductor>();

        public BaseDeDatos()
        {
        }

        public void Fill()
        {
            directores.Add(new Director("director 1", "apellido director 1", new DateTime(1987, 2, 25), "buen director"));
            directores.Add(new Director("director 2", "apellido director 2", new DateTime(1985, 7, 15), "mal director"));
            directores.Add(new Director("director 3", "apellido director 3", new DateTime(1977, 11, 5), "ahi nomas como director"));
            directores.Add(new Director("director 4", "apellido director 4", new DateTime(1967, 3, 22), "excelente director"));

            actores.Add(new Actor("actor 1", "apellido 1", new DateTime(1997, 9, 2), "buen actor"));
            actores.Add(new Actor("actor 2", "apellido 2", new DateTime(1967, 4, 21), "buen actor"));
            actores.Add(new Actor("actor 3", "apellido 3", new DateTime(1987, 1, 20), "buen actor"));
            actores.Add(new Actor("actor 4", "apellido 4", new DateTime(1927, 2, 25), "buen actor"));
            actores.Add(new Actor("actor 5", "apellido 5", new DateTime(1947, 11, 1), "buen actor"));

            productores.Add(new Productor("productor 1", "apellido 1", new DateTime(1934, 2, 13), "esta muertisimo"));
            productores.Add(new Productor("productor 2", "apellido 2", new DateTime(1944, 1, 1), "no tiene plata"));
            productores.Add(new Productor("productor 3", "apellido 3", new DateTime(1974, 12, 3), "es pesado"));
            productores.Add(new Productor("productor 4", "apellido 4", new DateTime(1984, 4, 3), "es drogadicto"));
            productores.Add(new Productor("productor 5", "apellido 5", new DateTime(1935, 7, 23), "esta loco"));

            estudios.Add(new Estudio("Universal Studios", "Carmen 124", new DateTime(1945, 12, 4)));
            estudios.Add(new Estudio("Universal Studios copia 1", "San Diego 24", new DateTime(1990, 2, 6)));
            estudios.Add(new Estudio("Universal Studios copia 2", "Santa Isabel 12", new DateTime(1955, 1, 4)));

            peliculas.Add(new Pelicula("sharknado 1", directores[0], new DateTime(2001, 1, 13), "malismia", 10000000, estudios[0]));
            peliculas.Add(new Pelicula("sharknado 2", directores[1], new DateTime(2001, 1, 13), "malismia", 15000000, estudios[1]));
            peliculas.Add(new Pelicula("sharknado 3", directores[2], new DateTime(2001, 1, 13), "malismia", 20000000, estudios[2]));

            PeliculaActors.Add(new PeliculaActor(actores[0], peliculas[0]));
            PeliculaActors.Add(new PeliculaActor(actores[1], peliculas[0]));
            PeliculaActors.Add(new PeliculaActor(actores[2], peliculas[0]));
            PeliculaActors.Add(new PeliculaActor(actores[3], peliculas[1]));
            PeliculaActors.Add(new PeliculaActor(actores[1], peliculas[1]));
            PeliculaActors.Add(new PeliculaActor(actores[2], peliculas[2]));
            PeliculaActors.Add(new PeliculaActor(actores[0], peliculas[2]));

            PeliculaProductors.Add(new PeliculaProductor(productores[0], peliculas[0]));
            PeliculaProductors.Add(new PeliculaProductor(productores[1], peliculas[0]));
            PeliculaProductors.Add(new PeliculaProductor(productores[2], peliculas[0]));
            PeliculaProductors.Add(new PeliculaProductor(productores[3], peliculas[0]));
            PeliculaProductors.Add(new PeliculaProductor(productores[4], peliculas[0]));
            PeliculaProductors.Add(new PeliculaProductor(productores[0], peliculas[1]));
            PeliculaProductors.Add(new PeliculaProductor(productores[1], peliculas[1]));
            PeliculaProductors.Add(new PeliculaProductor(productores[2], peliculas[1]));
            PeliculaProductors.Add(new PeliculaProductor(productores[3], peliculas[1]));
            PeliculaProductors.Add(new PeliculaProductor(productores[4], peliculas[1]));
            PeliculaProductors.Add(new PeliculaProductor(productores[0], peliculas[2]));
            PeliculaProductors.Add(new PeliculaProductor(productores[1], peliculas[2]));
            PeliculaProductors.Add(new PeliculaProductor(productores[2], peliculas[2]));
            PeliculaProductors.Add(new PeliculaProductor(productores[3], peliculas[2]));
            PeliculaProductors.Add(new PeliculaProductor(productores[4], peliculas[2]));

        }

    }
}

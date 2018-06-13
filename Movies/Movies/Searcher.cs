using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class Searcher : Form
    {
        BaseDeDatos data = BaseDeDatos.Deserialize_Product("BaseDeDatos.bin");
        private Iloger listener;
        public interface Iloger
        {
            void SendA(Actor persona);
            void SendD(Director persona);
            void SendP(Productor persona);
            void SendPe(Pelicula pelicula);
            void SendS(Estudio estudio);
        }


        public Searcher(object sender)
        {
            InitializeComponent();
            if (sender is Iloger)
            {
                listener = (Iloger)sender;
            }

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            List<Actor> OutA = new List<Actor>();
            IEnumerable<Actor> OpcionesA = data.actores.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Actor result in OpcionesA)
            {
                ListView.Items.Add(result.nombre + result.apellido);
                OutA.Add(result);
            }

            List<Director> OutD = new List<Director>();
            IEnumerable<Director> OpcionesD = data.directores.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Director result in OpcionesD)
            {
                ListView.Items.Add(result.nombre + " " + result.apellido);
                OutD.Add(result);
            }

            List<Productor> OutP = new List<Productor>();
            IEnumerable<Productor> OpcionesP = data.productores.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Productor result in OpcionesP)
            {
                ListView.Items.Add(result.nombre + " " + result.apellido);
                OutP.Add(result);
            }

            List<Pelicula> OutPe = new List<Pelicula>();
            IEnumerable<Pelicula> OpcionesPe = data.peliculas.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Pelicula result in OpcionesPe)
            {
                ListView.Items.Add(result.nombre);
                OutPe.Add(result);
            }

            List<Estudio> OutS = new List<Estudio>();
            IEnumerable<Estudio> OpcionesS = data.estudios.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Estudio result in OpcionesS)
            {
                ListView.Items.Add(result.nombre);
                OutS.Add(result);
            }
        }

        private void SearchMovies_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            List<Pelicula> OutPe = new List<Pelicula>();
            IEnumerable<Pelicula> OpcionesPe = data.peliculas.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Pelicula result in OpcionesPe)
            {
                ListView.Items.Add(result.nombre);
                OutPe.Add(result);
            }
        }

        private void SearchActors_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            List<Actor> Out = new List<Actor>();
            IEnumerable<Actor> Opciones = data.actores.Where(person => person.nombre == SearchBar.Text);
            foreach (Actor result in Opciones)
            {
                ListView.Items.Add(result.nombre + result.apellido);
                Out.Add(result);
            }
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

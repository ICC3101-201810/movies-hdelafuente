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

        List<Actor> OutA = new List<Actor>();
        List<Director> OutD = new List<Director>();
        List<Productor> OutP = new List<Productor>();
        List<Pelicula> OutPe = new List<Pelicula>();
        List<Estudio> OutS = new List<Estudio>();
        public Searcher()
        {
            InitializeComponent();
            data = BaseDeDatos.Deserialize_Product("BaseDeDatos.bin");
            PanelCriticas.Visible = false;
        }
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            OutA.Clear();
            OutD.Clear();
            OutP.Clear();
            OutPe.Clear();
            OutS.Clear();

            if (SearchBar.Text.Length < 3)
            {

            }
            else
            {
                IEnumerable<Actor> OpcionesA = data.actores.Where(person => person.nombre.Contains(SearchBar.Text));
                foreach (Actor result in OpcionesA)
                {
                    ListView.Items.Add(result.nombre + " " + result.apellido);
                    OutA.Add(result);
                }

                IEnumerable<Director> OpcionesD = data.directores.Where(person => person.nombre.Contains(SearchBar.Text));
                foreach (Director result in OpcionesD)
                {
                    ListView.Items.Add(result.nombre + " " + result.apellido);
                    OutD.Add(result);
                }

                IEnumerable<Productor> OpcionesP = data.productores.Where(person => person.nombre.Contains(SearchBar.Text));
                foreach (Productor result in OpcionesP)
                {
                    ListView.Items.Add(result.nombre + " " + result.apellido);
                    OutP.Add(result);
                }

                IEnumerable<Pelicula> OpcionesPe = data.peliculas.Where(person => person.nombre.Contains(SearchBar.Text));
                foreach (Pelicula result in OpcionesPe)
                {
                    ListView.Items.Add(result.nombre);
                    OutPe.Add(result);
                }

                IEnumerable<Estudio> OpcionesS = data.estudios.Where(person => person.nombre.Contains(SearchBar.Text));
                foreach (Estudio result in OpcionesS)
                {
                    ListView.Items.Add(result.nombre);
                    OutS.Add(result);
                }
            }

        }

        private void SearchMovies_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            OutPe.Clear();
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
            OutA.Clear();
            IEnumerable<Actor> Opciones = data.actores.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Actor result in Opciones)
            {
                ListView.Items.Add(result.nombre + " " +result.apellido);
                OutA.Add(result);
            }
        }

        private void SearchDirector_Click(object sender, EventArgs e)
        {
            OutD.Clear();
            ListView.Items.Clear();
            IEnumerable<Director> OpcionesD = data.directores.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Director result in OpcionesD)
            {
                ListView.Items.Add(result.nombre + " " + result.apellido);
                OutD.Add(result);
            }
        }

        private void SearchStudio_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            OutS.Clear();
            IEnumerable<Estudio> OpcionesS = data.estudios.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Estudio result in OpcionesS)
            {
                ListView.Items.Add(result.nombre);
                OutS.Add(result);
            }
        }

        private void SearchProducer_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            OutP.Clear();
            IEnumerable<Productor> OpcionesP = data.productores.Where(person => person.nombre.Contains(SearchBar.Text));
            foreach (Productor result in OpcionesP)
            {
                ListView.Items.Add(result.nombre + " " + result.apellido);
                OutP.Add(result);
            }
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Texto_Perfil.Text = " ";
            try
            {
                Texto_Perfil.Text = " ";
                int index = ListView.FocusedItem.Index;
                Texto_Perfil.Text += "Nombre: " + OutA[index].nombre + " " + OutA[index].apellido;
                Texto_Perfil.Text += "\nFecha nacimiento: " + OutA[index].fecha_nacimiento;
                Texto_Perfil.Text += "\nBiografia: " + OutA[index].biografia;
                goto Lugar;
            }
            catch { }
            try
            {
                Texto_Perfil.Text = " ";
                int index = ListView.FocusedItem.Index;
                Texto_Perfil.Text += "Nombre: " + OutD[index].nombre + " " + OutD[index].apellido;
                Texto_Perfil.Text += "\nFecha nacimiento: " + OutD[index].fecha_nacimiento;
                Texto_Perfil.Text += "\nBiografia: " + OutD[index].biografia;
                goto Lugar;
            }
            catch { }

            try
            {
                Texto_Perfil.Text = " ";
                int index = ListView.FocusedItem.Index;
                Texto_Perfil.Text += "Nombre: " + OutP[index].nombre + " " + OutP[index].apellido;
                Texto_Perfil.Text += "\nFecha nacimiento: " + OutP[index].fecha_nacimiento;
                Texto_Perfil.Text += "\nBiografia: " + OutP[index].biografia;
                goto Lugar;
            }
            catch { }
            try
            {
                Texto_Perfil.Text = " ";
                int index = ListView.FocusedItem.Index;
                Texto_Perfil.Text += "\nNombre: " + OutPe[index].nombre;
                Texto_Perfil.Text += "\nFecha estreno: " + OutPe[index].fecha_estreno;
                Texto_Perfil.Text += "\nDirector: " + OutPe[index].director.nombre + " " + OutPe[index].director.apellido;
                Texto_Perfil.Text += "\nEstudio: " + OutPe[index].estudio.nombre;
                Texto_Perfil.Text += "\nPresupuesto: " + OutPe[index].presupuesto;
                Texto_Perfil.Text += "\nDescripcion: " + OutPe[index].descripcion;
                Texto_Perfil.Text += "\n       Algunas criticas\n";
                foreach(Critica crit in OutPe[index].criticas)
                {
                    Texto_Perfil.Text += crit.nombre_emisor + ":\n";
                    Texto_Perfil.Text += "' " + crit.mensaje + " '\n";
                }

                goto Lugar;
            }
            catch { }
            try
            {
                Texto_Perfil.Text = " ";
                int index = ListView.FocusedItem.Index;
                Texto_Perfil.Text += "Nombre Estudio: " + OutS[index].nombre;
                Texto_Perfil.Text += "\nDireccion: " + OutS[index].direccion;
                Texto_Perfil.Text += "\nFecha de apretura: " + OutS[index].fecha_apertura;
                goto Lugar;
            }
            catch { }
            Lugar:
            Console.WriteLine("Easter Egg");
        }

        private void PanelCriticas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Boton_Criticas_Click(object sender, EventArgs e)
        {
            PanelCriticas.Visible = true;
            Perfil.Visible = false;
        }

        private void Send_Click_1(object sender, EventArgs e)
        {
            string nombre = BoxNombre.Text;
            string mensaje = BoxMensaje.Text;
            int index = ListView.FocusedItem.Index;
            Pelicula.RecibeCritica(nombre, mensaje, OutPe[index]);
            BaseDeDatos.Serialize_Product("BaseDeDatos.bin", data);
            PanelCriticas.Visible = false;
            Perfil.Visible = true;
            Perfil.Refresh();
        }
    }
}

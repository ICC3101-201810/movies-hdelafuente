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
    public partial class Perfil : Form, Searcher.Iloger
    {
        public Perfil()
        {
            InitializeComponent();

        }
        public void SendA(Actor persona)
        {

        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

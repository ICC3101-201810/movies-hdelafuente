using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BaseDeDatos data = new BaseDeDatos();
            data.Fill();
            PersistenciaInfo<BaseDeDatos>.Serialize_Product("BaseDeDatos.bin", data);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 a = new Form1();
            a.Show();
            System.Threading.Thread.Sleep(5000);
            a.Close();
            Application.Run(new Searcher());
            
        }
    }
}

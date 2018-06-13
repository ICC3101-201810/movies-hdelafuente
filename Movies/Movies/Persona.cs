using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        public DateTime fecha_nacimiento;
        public string biografia;

    public Persona(string nombre, string apellido, DateTime fecha_nacimiento, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.biografia = biografia;
        }
    }
}

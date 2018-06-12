using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    class Director : Persona
    {
        public Director(string nombre, string apellido, DateTime fecha_nacimiento, string biografia) : base(nombre, apellido, fecha_nacimiento, biografia)
        {

        }
    }
}

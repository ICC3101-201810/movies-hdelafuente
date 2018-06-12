using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    class Productor : Persona
    {
        public Productor(string nombre, string apellido, DateTime fecha_nacimiento, string biografia) : base(nombre, apellido, fecha_nacimiento, biografia)
        {

        }
    }
}

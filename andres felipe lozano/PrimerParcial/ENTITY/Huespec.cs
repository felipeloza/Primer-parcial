using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Huespec
    {
        public int Id { get; set; }
        public String Nombre{ get; set; }

        public Huespec()
        {
        }

        public Huespec(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return ($"{Id};{Nombre}");
        }
    }
}

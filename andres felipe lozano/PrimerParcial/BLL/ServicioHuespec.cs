using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioHuespec : Icrud<Huespec>
    {
        private MostrarHuespedes Archivo;
        private List<Huespec> huespedes;
        public ServicioHuespec()
        {
            Archivo = new MostrarHuespedes(NomArchivo.NombreHuespec);
        }

        public string Guardar(Huespec entidad)
        {
            if (buscar(entidad.Id) != null)
            {
                return "ya existe el usuario";
            }
            else
            {
                var messge = Archivo.guardar(entidad);
                return messge;
            }
                    
        }



        public List<Huespec> MostrarTodo()
        {
            huespedes = Archivo.MostrarDatos();
            return huespedes;
        }

        public Huespec buscar(int entidad)
        {
            MostrarHuespedes m = new MostrarHuespedes(NomArchivo.NombreHuespec);
            huespedes = m.MostrarDatos();
            foreach (var item in this.huespedes)
            {
                if (entidad == item.Id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}

using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioReserva
    {
        private MostrarReservas Archivo;
        private List<Reserva> reservas;
        public ServicioReserva()
        {
            Archivo = new MostrarReservas(NomArchivo.NombreReserva);
        }

        public string Guardar(Reserva entidad)
        {
            if (Search(entidad.IdReserva) != null) 
            {
                var messge = Archivo.guardar(entidad);
                return messge;
            }
            return "ya existe";
                
        }

        public List<Reserva> MostrarTodo()
        {
            reservas = Archivo.MostrarDatos();
            return reservas;
        }
        public string crearReserva(int idReserva, Huespec usuario,string descripcion, DateTime entrada, DateTime salida)
        {
            if (Search(idReserva) == null)
            {

                //verificar que la habitacion no este ocupada
                Reserva nueva = new Reserva( usuario, idReserva,descripcion, entrada, salida);
                this.reservas.Add(nueva);
                // poner la habitacion como ocupada o la fecha-------habitacion.Estado(true);
                return reservas.ToString();//reviar el toString
            }
            else
            {
                return "Reserva existente";
            }
        }

        public ENTITY.Reserva Search(int idReserva)
        {
            if (this.reservas == null)
            {
                return null;
            }
            else
            {
                foreach (var item in this.reservas)
                {
                    if (idReserva == item.IdReserva)
                    {
                        return item;
                    }
                }
            }

            return null;
        }
    }

}

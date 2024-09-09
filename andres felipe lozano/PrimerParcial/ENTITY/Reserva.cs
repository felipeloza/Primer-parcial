
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Reserva
    {
        public Huespec usuario;
        public int IdReserva { get; set; }
        public string Categoria { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaSalida { get; set; }



        public Reserva()
        {
        }

        public Reserva(Huespec usuario, int idReserva, string categoria, DateTime fechaInicio, DateTime fechaSalida)
        {
            this.usuario = usuario;
            this.IdReserva = idReserva;
            Categoria = categoria;
            FechaInicio = fechaInicio;
            FechaSalida = fechaSalida;
        }

        public override string ToString()
        {
            return ($"{IdReserva};{FechaInicio};{FechaSalida}; {Categoria}");
        }

       
    }
}

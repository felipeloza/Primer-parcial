using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class MostrarReservas : GuardarArchivo<Reserva>
    {
        public MostrarReservas(string filName) : base(filName)
        {
        }

       

        public override List<Reserva> MostrarDatos()
        {
            try
            {
                List<Reserva> tasks = new List<Reserva>();
                string line;
                StreamReader reader = new StreamReader(_fileNme);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    tasks.Add(Map(line));
                }
                reader.Close();
                return tasks;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private Reserva Map(string line)
        {
            Reserva Huespedes = new Reserva();
            Huespedes.IdReserva = int.Parse(line.Split(';')[0]);
            Huespedes.FechaInicio = DateTime.Parse(line.Split(';')[1]);
            Huespedes.FechaSalida = DateTime.Parse(line.Split(';')[1]);
            return Huespedes;
        }
    }
}


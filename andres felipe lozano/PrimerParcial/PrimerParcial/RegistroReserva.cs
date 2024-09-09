using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class RegistroReserva
    {
        public RegistroReserva()
        {

            Console.Clear();
            Console.WriteLine("*************RESGISTRO DE RESERVA*****************");
            Console.WriteLine("INGRESE SU IDENTIFICACION");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SU ID DE HABITACION");
            int idreser = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA CATEGORIA");
            string cat = Console.ReadLine();
            Console.WriteLine("INGRESE LA FECHA DE INICIO");
            DateTime fechaini = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA FECHA DE SALIDA");
            DateTime fechasali= DateTime.Parse(Console.ReadLine());

            ServicioHuespec servi = new ServicioHuespec();

            if (servi.buscar(id) == null) 
            {
                Console.WriteLine("usuari no registrado");
            }
            else
            {
                var Reserva = new Reserva
                {
                    usuario = servi.buscar(id),
                    IdReserva = idreser,
                    Categoria = cat,
                    FechaInicio = fechaini,
                    FechaSalida = fechasali,
                };
                ServicioReserva servicionu = new ServicioReserva(); 
                Console.WriteLine(servicionu.Guardar(Reserva));
            }
        }
    }
}

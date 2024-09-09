using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Menu
    {
        public void menu() 
        {
            
            int eleccion;
            do
            {
                Console.Clear();
                Console.WriteLine(" Sistema de gestion de tareas");
                Console.WriteLine(" \n 1.) REGISTRAR HUESPEC ");
                Console.WriteLine(" \n 2.) GESTIONAR RESERVA");
                Console.WriteLine(" \n 3.) COSTO TOTAL");
                Console.WriteLine(" \n 4.) DISPONIBILIDAD DE HABITACION");
                Console.WriteLine(" \n 5.) VISUALIZAR RESERVA");
                Console.WriteLine(" \n 6.) salir");

                eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1: new PrimerParcial.RegitroHuespec(); break;

                    case 2: new PrimerParcial.RegistroReserva(); break;

                    case 3:  break;

                    case 4:  break;

                    case 5: new PrimerParcial.mostrar(); break;
                    default: Console.WriteLine("datos invalidos"); break;
                }

            } while (eleccion != 6);
        }
        
    }
}

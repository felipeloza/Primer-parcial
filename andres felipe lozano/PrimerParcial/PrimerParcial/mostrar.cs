using BLL;
using ENTITY;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    internal class mostrar
    {
        public mostrar() {

            ServicioReserva servi = new ServicioReserva();
            var lista = servi.MostrarTodo();
            foreach (var task in lista)
            {
                Console.WriteLine($"{task.usuario}-{task.IdReserva}- {task.Categoria}-{task.FechaInicio}-{task.FechaSalida}");
            }
            Console.ReadKey();
        }
    }
}

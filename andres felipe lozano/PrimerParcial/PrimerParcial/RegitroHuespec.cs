using BLL;
using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    internal class RegitroHuespec
    {
        public RegitroHuespec() 
        {
            
            Console.Clear();
            Console.WriteLine("*************RESGISTRO DE HUESPEC*****************");
            Console.WriteLine("INGRESE SU IDENTIFICACION");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SU NOMBRE");
            string nom= Console.ReadLine();
            
            var huespec= new Huespec
            {
                Id = id,
                Nombre = nom,
            };
            ServicioHuespec servicioHuespec = new ServicioHuespec();    

            servicioHuespec.Guardar(huespec);
        }

        
    }
}

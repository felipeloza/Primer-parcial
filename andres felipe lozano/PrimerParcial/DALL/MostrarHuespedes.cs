using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class MostrarHuespedes : GuardarArchivo<ENTITY.Huespec>
    {
        public MostrarHuespedes(string filName) : base(filName)
        {

        }

        public override List<ENTITY.Huespec> MostrarDatos()
        {
            try
            {
                List<ENTITY.Huespec> tasks = new List<ENTITY.Huespec>();
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

        private Huespec Map(string line)
            {
                Huespec Huespedes = new Huespec();
                Huespedes.Id = int.Parse(line.Split(';')[0]);
                Huespedes.Nombre = line.Split(';')[1];

                return Huespedes;
            }
        }
    }

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public abstract class GuardarArchivo<T>
    {
        protected string _fileNme;

        protected GuardarArchivo(string filName)
        {
            _fileNme = filName;
        }
        public string guardar(T entidad)
        {
            try
            {
                StreamWriter Writer = new StreamWriter(_fileNme, true);
                Writer.WriteLine(entidad.ToString());
                Writer.Close();
                return "datos almacenados correctamente";
            }
            catch (Exception ex)
            {
                return ("error al guardar " + ex.Message);
            }

        }
        public abstract List<T> MostrarDatos();
    }
}

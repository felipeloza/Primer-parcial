using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface Icrud<T>
    {
        string Guardar(T entidad);
        Huespec buscar(int entidad);  
        List<T> MostrarTodo();
        

    }
}

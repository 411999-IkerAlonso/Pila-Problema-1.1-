using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1
{
    public interface IColleccion
    {
        bool EstaVacia();
        object Extraer();
        object Primero();
        bool Añadir(object objeto);
    }
}

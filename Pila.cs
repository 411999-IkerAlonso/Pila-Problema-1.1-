using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1
{
    public class Pila : IColleccion
    { 
        public object[] objetos {  get; set; }
        public int Contador {  get; set; }

        public Pila()
        {
            objetos = new object[0];
            Contador = 0;
        }

        public Pila(int capacidad)
        {
            objetos= new object[capacidad];
            Contador =0;
        }
        public bool Añadir(object obj1)
        {
            if (Contador < objetos.Length)
            {
                objetos[Contador] = obj1;
                Contador++;
                Console.WriteLine("Elemento añadido Exitosamente");
                return true;
            }
            else
            {
                Console.WriteLine("No se pudo añadir el elemento");
                return false;
            }
        }

        public bool EstaVacia()
        {
            if(objetos.Length == 0)
            {
                Console.WriteLine("La Pila Esta Vacia");
                return true;   
            }
            else 
            {
                Console.WriteLine("La Pila NO Esta Vacia");
                return false; 
            }
        }

        public object Extraer()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La pila está vacía.");
                return null;
            }
            Contador--; 
            object extraido = objetos[Contador];
            objetos[Contador] = null; //Limpia el lugar 
            return extraido;
        }

        public object Primero()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La pila está vacía.");
                return null;
            }
                return objetos[Contador - 1];
            
        }
    }
}

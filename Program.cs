using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1
{
//    Problema 1.1:
//Pilas.Escribe una interfaz, llamada IColleccion que declare los siguientes
//métodos:
//estaVacia() : devuelve true si la colección está vacía y false en caso contrario.
//extraer(): devuelve y elimina el primer elemento de la colección.
//primero(): devuelve el primer elemento de la colección.
//añadir(): añade un objeto por el extremo que corresponda, y devuelve true si
//se ha añadido y false en caso contrario.
//A continuación, escribe una clase Pila, que implemente esta interfaz,
//utilizando para ello un array de Object y un contador de objetos.
    internal class Program
    {
        static void Main(string[] args)
        {   
            Pila pila = new Pila(5); //Creo una PIla de 5 elementos
            pila.Añadir(5);
            pila.Añadir(8);
            pila.Añadir(19);
            Console.WriteLine("Último elemento (Primero): " + pila.Primero());

            // Extraer y mostrar el último elemento añadido
            Console.WriteLine("Elemento extraído: " + pila.Extraer());

            // Comprobar si la pila está vacía
            Console.WriteLine("¿Está vacía? " + pila.EstaVacia());

            // Extraer los elementos restantes
            Console.WriteLine("Elemento extraído: " + pila.Extraer());
            Console.WriteLine("Elemento extraído: " + pila.Extraer());

            // Comprobar si la pila está vacía de nuevo
            Console.WriteLine("¿Está vacía? " + pila.EstaVacia());

            // Intentar extraer de una pila vacía
            Console.WriteLine("Intentando extraer de una pila vacía...");
            pila.Extraer();

            // Intentar ver el primer elemento de una pila vacía
            Console.WriteLine("Intentando ver el primer elemento de una pila vacía...");
            pila.Primero();

            Console.ReadLine();
        }
    }
}

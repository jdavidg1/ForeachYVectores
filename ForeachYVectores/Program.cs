using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;      //línea agregada para generar el timer

namespace ForeachYVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definicón de vector y varibales
            
            int[] numero;
          
            //instanciar el vector

            numero = new int[5];

            numero[0] = 5;
            numero[2] = 2;

            foreach(int elemento in numero)
            {
                Console.WriteLine(elemento);
                Thread.Sleep(1000);  //Retado para que los escriba cada segundo los elementos
            }
            Console.ReadKey();
        }
    }
}

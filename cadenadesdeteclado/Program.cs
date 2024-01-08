using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenadesdeteclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string nombre; 

            //imprime la pregunta y funcion desde teclado 
            Console.WriteLine("Hola , Cual es tu nombre?");
            nombre = Console.ReadLine();

            //resultado
            Console.WriteLine("hola {0} , un placer ",nombre);

            Console.WriteLine("");

        }
    }
}

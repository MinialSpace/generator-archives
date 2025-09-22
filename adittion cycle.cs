using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace suma_numeros_while_AlirikBacon_ejc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe los numeros a sumar (Para terminar el programa escribe 0): ");
            int a = 0; //definimos a de tipo entero, 0 es para inicializar en un valor
            int x = Convert.ToInt32(Console.ReadLine());
            while (x > 0)
            {
                a += x; //acumula en a el valor de la x mas su valor de sumatoria anterior
                x = Convert.ToInt32(Console.ReadLine());//asignamos a x otra vez para que se acomule el dato de los ciclos anteriores acumulados en a
                if (x == 0)
                {
                    Console.WriteLine("El resultado de la sumatoria es: " + a);
                    break;
                }
            }
        }
    }
}
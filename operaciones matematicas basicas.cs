using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practica_AlirikBacon_shitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indica la operación que deseas realizar:");
            Console.WriteLine("1) Suma. ");
            Console.WriteLine("2) Resta. ");
            Console.WriteLine("3) Multiplicación. ");
            Console.WriteLine("4) División. ");//se escribe el menú
            int ca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el valor de x"); // se registra el valor tipo int
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el valor de y");// se registra un valor tipo double porque pudiera ser decimales
        double y = Convert.ToDouble(Console.ReadLine());
            switch (ca) // según el valor que obtuvimos de ca
            {
                case 1:
                    Console.WriteLine("la sumatoria es: " + (x + y));// para asignar el valor que se obtenga de la sumatoria se utiliza un signo +
                    break;
                case 2:
                    Console.WriteLine("la resta es: " + (x - y));
                    break;
                case 3:
                    Console.WriteLine("la multiplicacón es: " + (x * y));
                    break;
                case 4:
                    Console.WriteLine("La división es: " + (x / y));
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace do_while_ejercicio5_AlirikBacon
{
internal class Program
    {
    static void Main(string[] args)
        {
        int cont;
            do
                {
                Console.WriteLine("Escribe la contraseña: ");
                cont = Convert.ToInt32(Console.ReadLine());
                } while (cont != 123);// ! -> diferente de "123"
         Console.WriteLine("Contraseña correcta!");
        }
    }
}
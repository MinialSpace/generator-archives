namespace CicloFor_AlirikBacon
{
internal class Program
{
static void Main(string[] args)
{
Console.WriteLine("Escribe el número del que deseas conocer la tabla "); // escribir en la pantalla la instrucción

int f = Convert.ToInt32(Console.ReadLine());//leer la instrucción
convirtiendo una variable a número entero int i;//introducir una variable para poder realizar la operación for
for (i = 1;i <= 10; i++)// para i iniciando en 1 y teminando en 10 avanza de 1 en uno
{
            //la siguiente ecuación:
                int r = f*i; //resultado de multiplicar la tabla por el incremento
Console.WriteLine(f + " x "+ i +" = "+ r);//escribir tabla por el incremento igual al resultado
}
}
}
}
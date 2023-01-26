using System;

namespace ConsoleAppEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {//titulo
            Console.Title = "Las cuatro operaciones basicas";
            Console.WriteLine("acontinuacion introducir los valores a calcular");
            //definicion de variables
            int n1, n2, suma, resta, division, multiplicacion;

            Console.Write("introducir primer valor:");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("introducir segundo valor:");
            n2=int.Parse(Console.ReadLine());

            //proceso
            suma = n1 + n2;
            resta = n1 - n2;
            division = n1 / n2;
            multiplicacion = n1 * n2;

            Console.WriteLine($"el resultado de la suma es:{suma}");
            Console.ReadLine();
            Console.WriteLine($"resultado resta:{resta}");
            Console.ReadLine();
            Console.WriteLine($"el resultado de la division es: {division}");
            Console.ReadLine();
            Console.WriteLine($"el resultado de la multiplicacion es:{multiplicacion}");
            Console.ReadLine();



        }
    }
}

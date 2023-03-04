using System;
namespace NumerosPares;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriba el Número que desea comparar: ");
        int num1 = int.Parse(Console.ReadLine());

        if (num1 % 2 == 0)
        { 
            Console.WriteLine("{0} tu número es par", num1);
            }
            else
             {
            Console.WriteLine("{0} tu numero es impar", num1);
                }

    }
}

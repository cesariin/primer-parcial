
using System;
class Program
{
    static void Main(string[] args)
    {
        int num1 = 1;
        int num2 = 2;
        int sum = int.Parse(Console.ReadLine());    
        Console.WriteLine("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        sum = num1 + num2;
        Console.WriteLine("La suma de {1} y {1} es: {2}", sum);



    }

}

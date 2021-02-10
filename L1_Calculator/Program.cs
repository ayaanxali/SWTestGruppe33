using System;
using System.Dynamic;

namespace L1_Calculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var Calculater = new Calculator();
            double tal1, tal2;

            Console.WriteLine("Dette er en simpel lommeregner");
            Console.WriteLine(Calculater.Accumulator);
            Console.Write("Indtast første tal: ");
            tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Indtast andet tal: ");
            tal2 = Convert.ToDouble(Console.ReadLine());
            
            Calculater.Add(tal1,tal2);
            Console.WriteLine("The Result is = {0}",Calculater.Accumulator);

            Console.ReadLine();

            Calculater.Subtract(tal1,tal2);
            Console.WriteLine("The Result is = {0}", Calculater.Accumulator);

            Console.ReadLine();
            
            Calculater.Multiply(tal1,tal2);
            Console.WriteLine("The Result is = {0}", Calculater.Accumulator);
        }
    }
}

using System;
using System.Dynamic;

namespace L1_Calculator
{
    class Program
    { 
        public static Calculator Calculator = new Calculator();
       // public string InputOperator { get; set; }
       static void Main(string[] args)
       {
            Run();
       }

        public static void Run()
        {
            string inputOperator ="";
            double tal1, tal2; 

            while (true)
            {
                Console.WriteLine("Dette er en simpel lommeregner");
                Console.WriteLine(Calculator.Accumulator);
                Console.Write("Indtast første tal: {0} ", tal1 = Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Indtast operator: {0}", inputOperator);
                Console.Write("Indtast andet tal: {0}", tal2 = Convert.ToDouble(Console.ReadLine()));
                
                switch (inputOperator)
                {
                    case "+":

                        Calculator.Add(tal1, tal2);
                        break;
                    case "-":
                        Calculator.Subtract(tal1, tal2);
                        break;
                    case "/":
                        try
                        {
                            Calculator.Division(tal1, tal2);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Attempted to divide by zero. Result is 0,0");
                            throw;
                        }

                        break;
                    case "*":
                        Calculator.Multiply(tal1, tal2);
                        break;
                    case "^":
                        Calculator.Power(tal1, tal2);
                        break;
                }

                Console.WriteLine("The Result: {0}", Calculator.Accumulator);
                
                // vi skal have lavet et loop så hvis personen vil fortsætte med at beregne udfra sidste resultat, gør vi videre og benytter overload metoden. og hvis personen benytter clear vender vi tilbage til tidligere metode intil personen afslutter program. 

                // mangler at teste overload metoderne

                // mangler at teste exception og evt. tilføje flere se excersice GetBasic. 
            }
        }
    }
}

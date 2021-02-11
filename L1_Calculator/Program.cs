using System;
using System.Dynamic;
using System.Globalization;

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
            
            double tal1, tal2;

            Console.WriteLine("Dette er en simpel lommeregner");
            Console.WriteLine(Calculator.Accumulator);
            while (true)
            {
                
                Console.Write("Indtast første tal: \n" );
                tal1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Indtast operator: \n");
                var input3 = Console.ReadKey(true);
                Console.Write("Indtast andet tal: \n");
                tal2 = Convert.ToDouble(Console.ReadLine());


                switch (input3.KeyChar)
                {
                    case '+':

                        Calculator.Add(tal1, tal2);
                        break;
                    case '-':
                        Calculator.Subtract(tal1, tal2);
                        break;
                    case '/':
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
                    case '*':
                        Calculator.Multiply(tal1, tal2);
                        break;
                    case '^':
                        Calculator.Power(tal1, tal2);
                        break;
                    case 'c':
                        Calculator.Clear();
                        break;
                        
                }

                Console.WriteLine("The Result: {0}", Calculator.Accumulator);
               
                tal1=Convert.ToDouble(Console.ReadLine());
                Calculator.Add(tal1);
                Console.WriteLine("The new result; {0}",Calculator.Accumulator);

                // vi skal have lavet et loop så hvis personen vil fortsætte med at beregne udfra sidste resultat, gør vi videre og benytter overload metoden. og hvis personen benytter clear vender vi tilbage til tidligere metode intil personen afslutter program. 

                // mangler at teste overload metoderne

                // mangler at teste exception og evt. tilføje flere se excersice GetBasic. 
            }
        }
    }
}

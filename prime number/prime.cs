using System;
using System.Linq;

namespace prime_number
{
    class Program
    {

        private static int numberOutput;


        static void Main(string[] args)
        {

            while (true)
            {

            Console.Write("Type any number to see if it is a prime number: ");

            string numberInput = Console.ReadLine();

            
            try
            {
                numberOutput = Convert.ToInt32(numberInput);
               
                    if (numberOutput == 2)
                    {
                        Console.WriteLine("that is a prime number");
                        break;
                    }
                    if (numberOutput == 3)
                    {
                        Console.WriteLine("that is a prime number");
                        break;
                    }
                    if (numberOutput == 5)
                    {
                        Console.WriteLine("that is a prime number");
                        break;
                    }
                    if (numberOutput == 7)
                    {
                        Console.WriteLine("that is a prime number");
                        break;
                    }
                   
                    if (numberOutput == 1)
                    {
                        Console.WriteLine("that is not a prime number");
                        break;
                    }
                    if (numberOutput == 0)
                    {
                        Console.WriteLine("that is not a prime number");
                        break;
                    }


                    if (numberOutput % 2 == 0)
                    {
                        Console.WriteLine("that is not a prime number");
                        break;
                    }
                    if (numberOutput % 3 == 0)
                    {
                        Console.WriteLine("that is not a prime number");
                        break;
                    }
                    if (numberOutput % 5 == 0)
                    {
                        Console.WriteLine("that is not a prime number");
                        break;
                    }
                    if (numberOutput % 7 == 0)
                    {
                        Console.WriteLine("that is not a prime number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("that is a prime number");
                        break;
                    }
                  }

                catch (FormatException)
                    {
                        Console.WriteLine("that is not a number");
                        break;
                    }
               
            }
            Console.ReadLine();
        }
   
    }
}

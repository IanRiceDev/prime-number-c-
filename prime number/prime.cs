using System;


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

            

            int[] basePrimes = new int[4];
            basePrimes[0] = 2;
            basePrimes[1] = 3;
            basePrimes[2] = 5;
            basePrimes[3] = 7;

            int[] notPrimes = new int[2];
            notPrimes[0] = 0;
            notPrimes[1] = 1;
            
            
            try
            {
                numberOutput = Convert.ToInt32(numberInput);
                numberOutput = numberOutput % 2;
               
            }
            catch (FormatException)
            {
                Console.WriteLine("that is not a number");
                    break;
            }

            Console.WriteLine(numberOutput);
           

         
         
      
           
            }
            Console.ReadLine();
        }
   
    }
}

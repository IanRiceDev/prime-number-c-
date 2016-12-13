using System;


namespace prime_number
{
    class Program
    {
   
        static void Main(string[] args)
        {
            
            Console.Write("Type any number to see if it is a prime number: ");

            int numberInput = Convert.ToInt32(Console.ReadLine());
            byte count = 0;


            int[] basePrimes = new int[4];
            basePrimes[0] = 2;
            basePrimes[1] = 3;
            basePrimes[2] = 5;
            basePrimes[3] = 7;

            int[] notPrimes = new int[2];
            notPrimes[0] = 0;
            notPrimes[1] = 1;

            int listCount = 0;
            int numberOutput;
/*
            try
            {
             
            }
            catch(FormatException)
            {
                Console.WriteLine("That is not a number");
            }

*/


            

            
            foreach(int basePrime in basePrimes)
            {
                Console.WriteLine(basePrimes[count]);
                count += 1;
            }
            
            
           
            Console.ReadLine();













        }
    }
}

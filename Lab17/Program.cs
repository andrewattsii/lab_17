using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continues = true;
            bool intWorks = false;

            Console.WriteLine("Let's locate some primes!");

            Console.WriteLine("\nThis application will find you any prime, in order, from the first prime number on.");

            while (continues)
            {
                intWorks = false;
                int getPrime = 0;

                while (!intWorks)
                {
                    Console.Write("Which prime number are you looking for? ");
                    intWorks = int.TryParse(Console.ReadLine(), out getPrime);
                }
                int primeNumber = PrimeNumber.GetPrimeNumber(getPrime);

                Console.WriteLine($"\nThe number {getPrime} prime is {primeNumber}.");

                Console.Write("Do you want to find another prime number? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    continues = true;
                }

                else
                {
                    continues = false;
                }
            }
            Console.WriteLine("Good bye!");
        }
    }
}
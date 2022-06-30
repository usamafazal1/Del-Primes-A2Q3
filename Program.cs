using System;
using System.Linq;

namespace A2Q3
{
    internal class Program
    {
        //method to check if a number is prime or not
        static bool PrimeChecker(int number)
        {
            //make an array with some random numbers
            int a = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        
        //main method where we call prime checker and identify the prime numbers
        static void Main()
        {
            //fill non prime numbers in noPrimesList later after they are identified view method PrimeChecker
            int[] Primes = { 3, 5, 6, 7, 8, 9, 11, 13, 15, 16, 17, 19, 21, 23, 25, 27, 29, 31, 33 };
            int[] noPrimesList = new int[Primes.Length];

            //print the initial list
            Console.WriteLine("Initial array:");
            for (int i=0; i<Primes.Length; i++)
            {
                Console.Write(Primes[i] + " ");
            }
           


            //check each element in array if it is a prime number in this loop by using PrimeChecker method
            for (int i = 0; i < Primes.Length; i++)
            {
                bool condition = PrimeChecker(Primes[i]);
                if (condition == false)
                {
                    noPrimesList[i] = Primes[i]; 
                    
                    /* this approach places 0 in place of primes
                     * need a way to remove 0s and reduce length of the new array
                     */
                    
                }
                else
                {
                    continue;
                }
            }



            //removing duplicates of 0 (which were there in place of primenumbers) from the array
            noPrimesList = noPrimesList.Where(e => e != 0).ToArray();

            //print the noPrimesList
            Console.WriteLine("\n\nArray with prime numbers removed:");
            for (int i = 0; i < noPrimesList.Length; i++)
            {
                Console.Write(noPrimesList[i] + " ");
            }
            Console.WriteLine("\n\n\n\n");
        }

    }
 }


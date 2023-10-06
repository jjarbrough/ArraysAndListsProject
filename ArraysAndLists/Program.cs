using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = i+1;
            }
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var even = new List<int>();
            var odd = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even.Add(numbers[i]);
                }
                else
                {
                    odd.Add(numbers[i]);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            for(int i =0; i < even.Count; i++)
            {
                Console.Write(even[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i< odd.Count; i++)
            {
                Console.WriteLine(odd[i]);
            }
        }
    }
}

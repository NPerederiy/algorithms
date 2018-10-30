using System;
using System.Collections.Generic;

namespace Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            var divisors = GetAllDivisors(1000000000);

            foreach (var num in divisors)
                Console.Write($"{num} ");

            Console.ReadKey();   
        }

        static int[] GetAllDivisors(int num)
        {
            var divisors = new List<int> { 1, num };
            for (var i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);
                    if (num / i != i)
                        divisors.Add(num / i);
                }
            };
            divisors.Sort();
            return divisors.ToArray();
        }
    }
}

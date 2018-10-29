using System.IO;
using System.Collections.Generic;

namespace Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeNumbers = SieveOfEratosthenes.GetPrimeNumbers(99999);
            var output = "";

            foreach (var prime in primeNumbers)
            {
                output += $"{prime} ";
            }

            File.WriteAllText("OUTPUT.txt", output, System.Text.Encoding.UTF8);
        }
    }

    public class SieveOfEratosthenes
    {
        private static List<int> primeNumbers;

        public static int[] GetPrimeNumbers(int limit)
        {
            primeNumbers = new List<int>();
            for (int i = 1; i < limit; i++)
                primeNumbers.Add(i);
            Start();
            return primeNumbers.ToArray();
        }

        private static void Start()
        {
            int i = 1;
            while (i < primeNumbers.Count)
            {
                Step(primeNumbers[i], i);
                i++;
            }
        }

        private static void Step(int prime, int startFrom)
        {
            int i = startFrom + 1;
            while (i < primeNumbers.Count)
                if (primeNumbers[i] % prime == 0)
                {
                    primeNumbers.RemoveAt(i);
                }
                else i++;
        }
    }
}

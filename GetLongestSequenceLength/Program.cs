using System.IO;

namespace ZerosAndOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("INPUT.txt");

            File.WriteAllText("OUTPUT.txt", GetLongestSequenceLength(input).ToString());
        }

        private static int GetLongestSequenceLength(string input)
        {
            var maxnum = 0;
            var sequences = input.Split('0');

            foreach (var s in sequences)
                if (s.Length > maxnum)
                    maxnum = s.Length;

            return maxnum;
        }
    }
}
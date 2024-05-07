using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace BinaryGap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int output;
            while (true)
            {
                try
                {
                    Console.WriteLine("Hello, type in an integer to check its binary gap.");
                    input = Convert.ToInt32(Console.ReadLine());
                    output = CalculateBinaryGap(input);
                    Console.WriteLine(output);
                    break;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter a proper number!");
                }
            }
        }

        static int CalculateBinaryGap(int N)
        {
            string pattern = "(?!1)(0+)(?=1)";
            string stringInput = Convert.ToString(N, 2);
            string longestMatch = "";

            MatchCollection matches = Regex.Matches(stringInput, pattern);
            foreach (Match match in matches)
            {
                if (match.Value.Length > longestMatch.Length)
                {
                    longestMatch = match.Value;
                }
            }

            if (longestMatch == "")
            {
                return 0;
            }

            return longestMatch.Length;

        }
    }
}

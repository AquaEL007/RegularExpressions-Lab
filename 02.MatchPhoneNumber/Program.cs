using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359)( |-)(2)\2(\d{3})\2(\d{4}\b)";
            string input = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", matchCollection));
        }
    }
}

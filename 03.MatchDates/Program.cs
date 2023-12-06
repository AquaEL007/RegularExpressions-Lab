using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(?<separator>\.|-|/)(?<month>[A-Z][a-z]{2})\<separator>(?<year>\d{4})";
            string input = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(input, pattern);

            foreach (Match match in matchCollection)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}

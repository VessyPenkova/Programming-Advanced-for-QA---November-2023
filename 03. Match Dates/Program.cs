using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\b\d{2})(?<Separator>[\/\-\.])(?<month>[A-Z][a-z]{2})\k<Separator>(?<year>\d{4}\b)";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection validNames = regex.Matches(text);

            //Console.WriteLine(string.Join(", ", validNames));

            foreach (Match name in validNames)
            {
                Console.WriteLine($"Day: {name.Groups["day"]}, Month: {name.Groups["month"]}, Year: {name.Groups["year"]}");
            }       
        }
    }
}
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection match = regex.Matches(text);

            Console.WriteLine(string.Join(" ", match));
        }
    }
}
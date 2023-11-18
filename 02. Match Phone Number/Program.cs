using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(?<Separator>[\ \-])2\k<Separator>\d{3}\k<Separator>\d{4}\b";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection validNames = regex.Matches(text);

            Console.WriteLine(string.Join(", ", validNames));

            //foreach (Match name in validNames)
            //{
            //    Console.Write($"{name.Value}, ");
            //}
            //Console.WriteLine();
        }
    }
}
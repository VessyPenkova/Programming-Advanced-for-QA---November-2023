namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsSquence = Console.ReadLine()
                  .Split(" ")
                  .ToArray();

            var result = wordsSquence.Where(x => x.Length % 2 == 0 ).ToArray();

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }           
        }
    }
}
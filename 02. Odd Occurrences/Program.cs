namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsSquence = Console.ReadLine()
                  .Split(" ")
                  .Select(x => x.ToLower())
                  .ToArray();

            Dictionary<string, int> counts = new();

            foreach (string word in wordsSquence)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word] += 1;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write($"{count.Key} ");
                }              
            }
        }
    }
}
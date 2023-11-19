namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordSequences = Console.ReadLine();
          
             Dictionary<char, int> counts = new();

            foreach (char ch in wordSequences)
            {
                if (counts.ContainsKey(ch))
                {
                    counts[ch] += 1;
                }
                else
                {
                    counts[ch] = 1;
                }
            }
            foreach (var count in counts)
            {
                if (count.Key != ' ')
                {
                    Console.WriteLine($"{count.Key} -> {count.Value}");
                }
                
            }
        }
    }
}
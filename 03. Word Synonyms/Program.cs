namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countInput = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synomimus =
            new Dictionary<string, List<string>>();

            for (int i = 0; i < countInput; i++)
            {
                string kayName = Console.ReadLine();
                string valueName = Console.ReadLine();
                if (synomimus.ContainsKey(kayName))
                {
                    synomimus[kayName].Add(valueName);
                }
                else
                {
                    synomimus.Add(kayName, new List<string>() { valueName });
                }
            }

            foreach (var word in synomimus)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)} ");
            }
        }
    }
}
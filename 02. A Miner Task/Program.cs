using System.Diagnostics.Metrics;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = "";
            Dictionary<string, int> minnerTask = new();

            while (key != "stop")
            {
                key = Console.ReadLine();
                if (key == "stop")
                {
                    break;
                }
                int value = int.Parse(Console.ReadLine());

                if (minnerTask.ContainsKey(key))
                {
                    minnerTask[key] += value;
                }
                else
                {
                    minnerTask[key] = value;
                }
            }

            foreach (var item in minnerTask)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
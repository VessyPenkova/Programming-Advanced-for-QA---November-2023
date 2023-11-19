using System.Globalization;

namespace _06._Company_Users__not_included_in_final_score_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesInfo = new();
            string info = Console.ReadLine();

            while (info != "End")
            {               
                string[] infoParts = info
                    .Split(" -> ")
                    .ToArray();
                string companyName = infoParts[0];
                string employeeId = infoParts[1];

                if (!companiesInfo.ContainsKey(companyName) )
                {
                    companiesInfo.Add(companyName, new List<string>());
                }
                if (!companiesInfo[companyName].Contains(employeeId))
                {
                    companiesInfo[companyName].Add(employeeId);
                }
                info = Console.ReadLine();
            }
            foreach (KeyValuePair <string, List<string>> currentCompany in companiesInfo)
            {
                Console.WriteLine(currentCompany.Key);
                foreach (string currentEmplyeed in currentCompany.Value)
                {
                    Console.WriteLine($"-- {currentEmplyeed}");
                }
            }
        }
    }
}
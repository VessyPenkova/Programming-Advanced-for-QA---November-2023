using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp___03___02
{
    public class Grades
    {
        public static string GetBestStudents(Dictionary<string, int> grades)
        {
            if (grades.Count == 0)
            {
                return string.Empty;
            }

            var bestThreeGrades = grades
                .OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .Take(3);

            StringBuilder sb = new();
            foreach (KeyValuePair<string, int> pair in bestThreeGrades)
            {
                sb.AppendLine($"{pair.Key} with average grade {pair.Value:f2}");
            }

            return sb.ToString().Trim();
        }
    }
}

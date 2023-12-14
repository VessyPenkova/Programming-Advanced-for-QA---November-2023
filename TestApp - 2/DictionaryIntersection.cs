using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp___2
{
    public class DictionaryIntersection
    {
        public static Dictionary<string, int> Intersect(
            Dictionary<string, int> dict1,
            Dictionary<string, int> dict2)
        {
            Dictionary<string, int> intersection = new();

            foreach (KeyValuePair<string, int> kvp in dict1)
            {
                if (dict2.ContainsKey(kvp.Key) && dict2[kvp.Key] == kvp.Value)
                {
                    intersection[kvp.Key] = kvp.Value;
                }
            }

            return intersection;
        }
    }

}

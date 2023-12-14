using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1901._TestApp
{
    
    public class CsvParser
    {
        public static string[] ParseCsv(string csvData)
        {
            if (string.IsNullOrEmpty(csvData))
            {
                return Array.Empty<string>();
            }

            return csvData.Trim().Split(',', StringSplitOptions.TrimEntries);
        }
    }

}



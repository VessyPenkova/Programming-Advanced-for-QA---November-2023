using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp___03___01
{
    public class SubstringExtractor
    {
        public static string ExtractSubstringBetweenMarkers(string input, string startMarker, string endMarker)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Substring not found";
            }

            int startIndex = input.IndexOf(startMarker, StringComparison.Ordinal);
            int endIndex = input.IndexOf(endMarker, startIndex + startMarker.Length, StringComparison.Ordinal);

            if (startIndex != -1 && endIndex != -1)
            {
                return input.Substring(startIndex + startMarker.Length, endIndex - startIndex - startMarker.Length);
            }

            return "Substring not found";
        }
    }
}

using System.Xml.Linq;

namespace _03._Sum_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr= Console.ReadLine()
                .Split(" ")
                .ToArray();
            int sum = 0;
            
            for (int i = 0; i < inputArr.Length; i++)
            {
                try
                {
                   int numberInt = int.Parse(inputArr[i]);
                    sum += numberInt;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{inputArr[i]}' is out of range!");
                }
                catch (FormatException)
                {

                    Console.WriteLine($"The element '{inputArr[i]}' is in wrong format!");
                }
                finally 
                {
                    Console.WriteLine($"Element '{inputArr[i]}' processed - current sum: {sum}");
                }              
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}

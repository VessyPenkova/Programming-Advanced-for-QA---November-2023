using System.Diagnostics;

namespace _05._Play_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            int numOfExceptions = 0;

            while (numOfExceptions < 3)
            {
                string[] comandParam = command.Split(" ");

                try
                {

                    if (comandParam[0] == "Replace")
                    {
                        int index = int.Parse(comandParam[1]);
                        int element = int.Parse(comandParam[2]);

                        integers[index] = element;
                    }
                    else if (comandParam[0] == "Print")
                    {
                        int starItindex = int.Parse(comandParam[1]);
                        int endIndex = int.Parse(comandParam[2]);
                        int counter = 0;

                        int[] toPrint = new int[endIndex - starItindex + 1];

                        for (int i = starItindex; i <= endIndex; i++)
                        {
                            toPrint[counter] = integers[i];
                            counter++;
                        }
                        Console.WriteLine(string.Join(", ", toPrint));
                    }
                    else if (comandParam[0] == "Show")
                    {
                        int index = int.Parse(comandParam[1]);
                        Console.WriteLine(integers[index]);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The varieble is not in the correct format!");
                    numOfExceptions++;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    numOfExceptions++;
                }
                finally
                {
                    if (numOfExceptions < 3)
                    {
                        command = Console.ReadLine();
                    }                  
                }              
            }
            Console.WriteLine(string.Join(", ", integers)); 
        }
    }
}

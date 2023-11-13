namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i <= stringArr.Length-1; i++)
            {
                string currentString = stringArr[i];
                for (int j = 0; j <= currentString.Length-1; j++)
                {
                    Console.Write(currentString);
                }
            }
        }
    }
}
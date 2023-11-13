namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToCheck = Console.ReadLine();

            List<int> integersList = new List<int>();
            List<char> letters = new List<char>();
            List<char> simbols = new List<char>();

            foreach (char item in stringToCheck)
            {               
                if (char.IsLetter(item))
                {
                    letters.Add(item);                   
                }
                if (char.IsDigit(item))
                {                              
                    integersList.Add((item-'0'));             
                }               
                if (!char.IsLetterOrDigit(item))
                {
                    simbols.Add(item);
                }
            }
            Console.WriteLine(String.Join((""), integersList));
            Console.WriteLine(String.Join((""), letters));
            Console.WriteLine(String.Join((""), simbols));
        }       
    }
}

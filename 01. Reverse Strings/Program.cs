namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = String.Empty;
          //  string reversedWord = String.Empty;

            List<string> wordList = new List<string>();
            List<string> reversedWorList = new List<string>();
         
            while (word!="end")
            {
                word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord =  new string(charArray);

                Console.WriteLine($"{word} = {reversedWord}");

            }
            
        }
    }
}
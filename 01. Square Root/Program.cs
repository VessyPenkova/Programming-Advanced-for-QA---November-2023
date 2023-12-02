namespace _01._Square_Root;

public class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        try
        {
            if (input < 0)
            {
                // throw new System.ArgumentOutOfRangeException("value",
                // "Sqrt for negative numbers is undefined!");
                throw new Exception();
            }
            double sqrt = Math.Sqrt(input);
            Console.WriteLine(sqrt);
        }
        catch //(ArgumentOutOfRangeException ex)
        {
            //Console.Error.WriteLine("Error: " + ex.Message);
            //throw;
            Console.WriteLine("Invalid number." );
        }  
        finally
        { 
            Console.WriteLine("Goodbye."); 
        }
    }
}


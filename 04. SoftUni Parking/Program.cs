namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            int counter = int.Parse(Console.ReadLine());

            Dictionary <string, string> registerSoftuUniParking = new ();

            for (int i = 0; i < counter; i++)
            {
                command = Console.ReadLine();
                string[] commandsPars = command.Split(" ");
                string comandFirstParts = commandsPars[0];
                if (comandFirstParts == "register")
                {
                    string userNmae = commandsPars[1];
                    string licensePlateNumber = commandsPars[2];
                    if (registerSoftuUniParking.ContainsKey(userNmae))
                    {
                        string plate = registerSoftuUniParking[userNmae];
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                    if (!registerSoftuUniParking.ContainsKey(userNmae))
                    {
                        Console.WriteLine($"{userNmae} registered {licensePlateNumber} successfully");
                        registerSoftuUniParking.Add(userNmae, licensePlateNumber);
                       
                    }
                }
                else if(comandFirstParts == "unregister")
                {
                    string userNmae = commandsPars[1];
                    if (registerSoftuUniParking.ContainsKey(userNmae))
                    {
                        Console.WriteLine($"{userNmae} unregistered successfully");
                        registerSoftuUniParking.Remove(userNmae);
                    }
                    else
                    //if (!registerSoftuUniParking.ContainsKey(userNmae))
                    {
                        Console.WriteLine($"ERROR: user {userNmae} not found");
                    }
                }
            }
            foreach (var registration in registerSoftuUniParking)
            {
                Console.WriteLine($"{registration.Key} => {registration.Value}");
            }
        }
    }
}
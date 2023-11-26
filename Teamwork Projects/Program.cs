using System.Linq;

namespace Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());

            Dictionary< string, Team> teams = new Dictionary< string, Team>();

            for (int i = 0; i < countTeams; i++)
            {
                string[] info = Console.ReadLine().Split("-");
                string creator = info[0];
                string teamName = info[1];

                if (!teams.Keys.Contains(teamName))
                {
                    Team team = new Team(teamName, creator);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    teams.Add(teamName, team);
                }
                if (teams.Keys.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }    
                //if (teams[teamName].Members.Contains(creator))
                //{
                //    if (teams[teamName].Members.Contains(creator))
                //    {
                //        Console.WriteLine($"{creator} cannot create another team!");
                //    }
                //}                
            }
            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string[] parts = command.Split("->");
                string currentUserToJoin = parts[0];
                string nameOfTheTeamToJoinIn = parts[1];
                if (!teams.Keys.Contains(nameOfTheTeamToJoinIn))//Check if the Team Existing
                {
                    Console.WriteLine($"Team {nameOfTheTeamToJoinIn} does not exist!");
                }
                if () )//Check if the currentUser is in another Team
                {
                    Console.WriteLine($"Member {currentUserToJoin} cannot join team {nameOfTheTeamToJoinIn}!");
                }
                else if (teams.Keys.Contains(nameOfTheTeamToJoinIn))
                {
                    teams[nameOfTheTeamToJoinIn].Members.Add(currentUserToJoin);
                }


                command = Console.ReadLine();
            }

            //3. Printing
            //1 type Teams without Members
            //2 type Teams with Members 

            foreach (var team in teams.Where(team => team.Value.Members.Count > 0)
                .OrderByDescending(team => team.Value.Members.Count)
                .ThenBy(team => team.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine("- " + team.Value.Creator);

            }

            Console.WriteLine("Teams to disband: ");
            foreach (var team in teams.Where(team => team.Value.Members.Count == 0))
            {
                Console.WriteLine(team.Key);
            }
        }
    }
}

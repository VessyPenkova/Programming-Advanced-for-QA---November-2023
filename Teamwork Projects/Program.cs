using System.Linq;

namespace Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());

            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            for (int i = 0; i < countTeams; i++)
            {
                string[] info = Console.ReadLine().Split("-");
                string creator = info[0];
                string teamName = info[1];

                if (teams.Keys.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");

                }
                else if (teams.Any(t => t.Value.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(teamName, team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] parts = command.Split("->");
                string currentUserToJoin = parts[0];
                string nameOfTheTeamToJoinIn = parts[1];

                if (!teams.Keys.Contains(nameOfTheTeamToJoinIn))//Check if the Team Existing
                {
                    Console.WriteLine($"Team {nameOfTheTeamToJoinIn} does not exist!");
                    continue;
                }

                var userIsCreator = teams[nameOfTheTeamToJoinIn].Creator == currentUserToJoin;
                var isUserAlreadyExist = teams.Values.Any(t => t.Members.Contains(currentUserToJoin));

                if (userIsCreator || isUserAlreadyExist)
                {
                    Console.WriteLine($"Member {currentUserToJoin} cannot join team {nameOfTheTeamToJoinIn}!");
                    continue;
                }

                var validTeams = teams
                    .Where(t => t.Value.Members.Count > 0)
                    .OrderBy(t => t.Value.Name)
                    .ToDictionary(t => t.Key, t => t.Value);

                var emptyTeams = teams
                 .Where(t => t.Value.Members.Count == 0)
                .OrderBy(t => t.Value.Name)
                .ToDictionary(t => t.Key, t => t.Value);


                //3. Printing
                //1 type Teams without Members
                //2 type Teams with Members 

                foreach (var team in validTeams.Values.OrderByDescending(t => t.Members.Count))
                {
                    Console.WriteLine($"{team.Name}");
                    Console.WriteLine($"- {team.Creator}");

                    foreach (var member in team.Members.OrderBy(m => m))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }

                Console.WriteLine("Teams to disband:");

                foreach (var emptyTeam in emptyTeams.Values)
                {
                    Console.WriteLine($"{emptyTeam.Name}");
                }
            }          
        }
    }
}

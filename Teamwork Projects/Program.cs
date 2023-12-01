using System.Linq;

namespace Teamwork_Projects
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());

            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            for (int i = 0; i < countTeams; i++)
            {
                string[] info = Console.ReadLine().Split('-');
                string creator = info[0];
                string teamName = info[1];

                if (teams.Keys.Contains(teamName))// Check if the teams Already exist
                {
                    Console.WriteLine($"Team {teamName} was already created!");

                }
                else if (teams.Any(t => t.Value.Creator == creator))// Check if the name of creator isnt equal to the name of he creator
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else// if Above conditionas are false then create team and add it to the collection
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(teamName, team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

            }
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] parts = command.Split("->").ToArray();
                string user = parts[0];
                string teamName = parts[1];

                if (!teams.Keys.Contains(teamName))//Check if the Team Existing
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                var userIsCreator = teams[teamName].Creator == user;
                var isUserAlreadyExist = teams.Values.Any(t => t.Members.Contains(user));

                if (userIsCreator || isUserAlreadyExist)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                teams[teamName].Members.Add(user);
            }
            var validTeams = teams
               .Where(t => t.Value.Members.Count > 0)
               .OrderBy(t => t.Value.Name)
               .ToDictionary(t => t.Key, t => t.Value);

            var emptyTeams = teams
                .Where(t => t.Value.Members.Count == 0)
                .OrderBy(t => t.Value.Name)
                .ToDictionary(t => t.Key, t => t.Value);

            foreach (var team in validTeams.Values.OrderByDescending(t => t.Members.Count))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");//Pring the Teams with Zero members

            foreach (var emptyTeam in emptyTeams.Values)
            {
                Console.WriteLine($"{emptyTeam.Name}");
            }
        }
    }
}

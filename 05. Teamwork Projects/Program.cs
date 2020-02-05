using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    public class Team
    {
        public string TeamCreator { get; set; }
        public string TeamName { get; set; }

        public List<string> Members { get; set; }

        public Team(string creator, string teamName, List<string> members)
        {
            this.TeamCreator = creator;
            this.TeamName = teamName;
            this.Members = members;
        }

    }
    class Program
    {
        static void Main()
        {
            int teamNumber = int.Parse(Console.ReadLine());
            List<Team> teamtList = new List<Team>();
            for (int i = 0; i < teamNumber; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string creator = input[0];
                string team = input[1];
                List<string> memberList = new List<string>();

                if (teamtList.Any(x => x.TeamName == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }

                else if (teamtList.Any(x => x.TeamCreator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                else
                {
                    Team newTeam = new Team(creator, team, memberList);
                    teamtList.Add(newTeam);
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }

            }
            while (true)
            {
                string inp = Console.ReadLine();

                if (inp == "end of assignment")
                {
                    break;
                }

                string[] input = inp.Split("->");
                string member = input[0];
                string team = input[1];

                if (!teamtList.Exists(x => x.TeamName == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }

                if (teamtList.Any(x => x.Members.Contains(member)) || teamtList.Any(t => t.TeamCreator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    continue;
                }

                for (int i = 0; i < teamtList.Count; i++)
                {
                    Team currentTeam = teamtList[i];

                    if (team == currentTeam.TeamName)
                    {
                        currentTeam.Members.Add(member);
                        continue;
                    }

                }

            }
            List<string> disbandList = new List<string>();

            teamtList = teamtList.OrderByDescending(x => x.Members.Count).ThenBy(t => t.TeamName).ToList();

            for (int i = 0; i < teamtList.Count; i++)
            {
                Team currentTeam = teamtList[i];

                if (currentTeam.Members.Count != 0)
                {
                    currentTeam.Members = currentTeam.Members.OrderBy(x => x).ToList();
                    Console.WriteLine(currentTeam.TeamName);
                    Console.WriteLine("- " + currentTeam.TeamCreator);
                    int countOfMembers = currentTeam.Members.Count;
                    for (int j = 0; j < countOfMembers; j++)
                    {
                        Console.WriteLine("-- " + currentTeam.Members[j]);
                    }

                }

                else
                {
                    disbandList.Add(currentTeam.TeamName);
                }

            }
            Console.WriteLine("Teams to disband:");
            if (disbandList.Count > 0)
            {
                disbandList = disbandList.OrderBy(x => x).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, disbandList));
            }
        }
    }

}

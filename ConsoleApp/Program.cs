using System;
using System.Collections.Generic;

namespace SuperAutoProfessionals.ConsoleApp;

internal class Program
{

    //create prof by codename, health, and attack input
    static Professional? CreateProfessionalByCodeName(string codeName, int attNum, int hthNum)
    {
        switch (codeName)
        {
            default: return null;

            case "Bu": return new Buthcer()
            {
                Attack = attNum,
                Health = hthNum
            };
            case "Pr": return new Professional()
            {
                Attack = attNum,
                Health = hthNum
            }; 
            case "Ch": return new Chef()
            {
                Attack = attNum,
                Health = hthNum
            };
            case "GD": return new GraveDigger()
            {
                Attack = attNum,
                Health = hthNum
            };
            case "Lw": return new Lawyer()
            {
                Attack = attNum,
                Health = hthNum
            };
            case "So": return new Soldier()
            {
                Attack = attNum,
                Health = hthNum
            };
            case "Tr": return new Trainer()
            {
                Attack = attNum,
                Health = hthNum
            };
            case "Nu": return new Nurse()
            {
                Attack = attNum,
                Health = hthNum
            };
            case "Dc": return new Doctor()
            {
                Attack = attNum,
                Health = hthNum
            };
            case "-": return null;
               

        }
    }


    // Create a method to build a team of professionals
    private static List<Professional> BuildTeam(string teamName)
    {
        List<Professional> team = new List<Professional>();

        for (int i = 0; i < 5; i++)
        {
            int attNum = 0, hthNum = 0;
            string codeName;

            Console.WriteLine($"Enter {teamName} team professional at " + (i + 1) + ": ");

            //read in codename
            while (true)
            {
                Console.WriteLine("Code Name: ");
                codeName = Console.ReadLine();
                if (codeName == "-")
                {
                   break;
                }
                else if (validCodeNames.Contains(codeName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid professional");
                }
            }

            if (codeName != "-")
            {
                //read in attack
                while (true)
                {
                    Console.WriteLine("Attack: ");
                    string attStr = Console.ReadLine();
                    if (int.TryParse(attStr, out attNum) && attNum >= 1 && attNum <= 50)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Attack must be between 1 and 50.");
                    }
                }

                //read in health
                while (true)
                {
                    Console.WriteLine("Health: ");
                    string hthStr = Console.ReadLine();
                    if (int.TryParse(hthStr, out hthNum) && hthNum >= 0 && hthNum <= 50)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Health must be between 0 and 50.");
                    }
                }
            }
                

            team.Add(CreateProfessionalByCodeName(codeName, attNum, hthNum));
        }

        return team;
    }







    //list of valid codenames
    private static List<string> validCodeNames = new List<string> { "Bu", "Pr", "Ch", "GD", "Lw", "So", "Tr", "Nu", "Dc", "-" };

    static void Main()
    {

        List<Professional> left = BuildTeam("left");
        List<Professional> right = BuildTeam("right");


		var game = new Game(new Team(left, Side.Left), new Team(right, Side.Right));

		var winner = game.RunTurn().Result;

		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine(winner == null ? "Draw" : $"Winner: {winner.Side}");
	}
}

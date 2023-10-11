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

    //list of valid codenames
    private static List<string> validCodeNames = new List<string> { "Bu", "Pr", "Ch", "GD", "Lw", "So", "Tr", "Nu", "Dc" };

    static void Main()
    {

        //inits
        string codeName;
        string attStr;
        string hthStr;


        List<Professional> left = new List<Professional>();
        
		//left team user input
        for (int i = 0; i < 5; i++)
        {

            int attNum, hthNum;
            
            Console.WriteLine("Enter left team professional at " + (i + 1) + ": ");

          
            //read in codename
            while (true)
            {
                Console.WriteLine("Code Name: ");
                codeName = Console.ReadLine();
                if (validCodeNames.Contains(codeName))
                {
                    break; // Break the loop when valid input is provided.
                }
                else
                {
                    Console.WriteLine("Invalid professional");
                }
            }
            //read in attack
            while (true)
            {
                Console.WriteLine("Attack: ");
                attStr = Console.ReadLine();
                if (int.TryParse(attStr, out attNum) && attNum >= 1 && attNum <= 50)
                {
                    break; // Break the loop when valid input is provided.
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
                hthStr = Console.ReadLine();
                if (int.TryParse(hthStr, out hthNum) && hthNum >= 0 && hthNum <= 50)
                {
                    break; // Break the loop when valid input is provided.
                }
                else
                {
                    Console.WriteLine("Invalid input. Health must be between 1 and 50.");
                }
            }


            left.Add(CreateProfessionalByCodeName(codeName, attNum, hthNum));


        }



        //create right team
         List<Professional> right = new List<Professional>();

        //right team user input
        for (int i = 0; i < 5; i++)
        {

            int attNum, hthNum;

            Console.WriteLine("Enter right team professional at " + (i + 1) + ": ");

            //read in codename
            while (true)
            {
                Console.WriteLine("Code Name: ");
                codeName = Console.ReadLine();
                if (validCodeNames.Contains(codeName))
                {
                    break; // Break the loop when valid input is provided.
                }
                else
                {
                    Console.WriteLine("Invalid professional");
                }
            }

            //read in attack
            while (true)
            {
                Console.WriteLine("Attack: ");
                attStr = Console.ReadLine();
                if (int.TryParse(attStr, out attNum) && attNum >= 1 && attNum <= 50)
                {
                    break; // Break the loop when valid input is provided.
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
                hthStr = Console.ReadLine();
                if (int.TryParse(hthStr, out hthNum) && hthNum >= 0 && hthNum <= 50)
                {
                    break; // Break the loop when valid input is provided.
                }
                else
                {
                    Console.WriteLine("Invalid input. Health must be between 1 and 50.");
                }
            }


            right.Add(CreateProfessionalByCodeName(codeName, attNum, hthNum));

        }



		var game = new Game(new Team(left, Side.Left), new Team(right, Side.Right));

		var winner = game.RunTurn().Result;

		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine(winner == null ? "Draw" : $"Winner: {winner.Side}");
	}
}

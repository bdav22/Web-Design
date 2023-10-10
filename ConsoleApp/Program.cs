using System;
using System.Collections.Generic;

namespace SuperAutoProfessionals.ConsoleApp;

internal class Program
{


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
            
            Console.WriteLine("Enter left team professional at " + (i + 1) + ": ");

            //read in codename
            Console.WriteLine("Code Name: ");
            codeName = Console.ReadLine();

            //read in attack
            Console.WriteLine("Attack: ");
            attStr = Console.ReadLine();
            if (int.TryParse(attStr, out int attNum)) ;

            //read in health
            Console.WriteLine("Health: ");
            hthStr = Console.ReadLine();
            if (int.TryParse(hthStr, out int hthNum)) ;

            
            left.Add(CreateProfessionalByCodeName(codeName, attNum, hthNum));


        }




        List<Professional> right = new List<Professional>();

        //right team user input
        for (int i = 0; i < 5; i++)
        {

            Console.WriteLine("Enter right team professional at " + (i + 1) + ": ");

            //read in codename
            Console.WriteLine("Code Name: ");
            codeName = Console.ReadLine();

            //read in attack
            Console.WriteLine("Attack: ");
            attStr = Console.ReadLine();
            if (int.TryParse(attStr, out int attNum)) ;

            //read in health
            Console.WriteLine("Health: ");
            hthStr = Console.ReadLine();
            if (int.TryParse(hthStr, out int hthNum)) ;

           

            right.Add(CreateProfessionalByCodeName(codeName, attNum, hthNum));


        }



		var game = new Game(new Team(left, Side.Left), new Team(right, Side.Right));

		var winner = game.RunTurn().Result;

		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine(winner == null ? "Draw" : $"Winner: {winner.Side}");
	}
}

using System;
using System.Collections.Generic;

namespace SuperAutoProfessionals.ConsoleApp;

internal class Program
{
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

            Professional newProfessional = new Professional
            {
                Attack = attNum,
                Health = hthNum,
                CodeName = codeName
            };
            
            left.Add(newProfessional);


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

            Professional newProfessional = new Professional
            {
                Attack = attNum,
                Health = hthNum,
                CodeName = codeName
            };

            right.Add(newProfessional);


        }



		var game = new Game(new Team(left, Side.Left), new Team(right, Side.Right));

		var winner = game.RunTurn().Result;

		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine(winner == null ? "Draw" : $"Winner: {winner.Side}");
	}
}

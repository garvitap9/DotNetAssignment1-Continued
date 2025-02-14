using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[5]
            {
                new Player(18, "Virat", 35),
                new Player(10, "Sachin", 30),
                new Player(7, "Dhoni", 33),
                new Player(21, "Nehal"),
                new Player(14, "Bumrah", 27)
            };
            Console.WriteLine("Details of the Players: ");
            foreach (Player player in players)
            {
                player.DisplayPlayerDetails();
            }

            Player eldestPlayer = players[0];
            for (int i =1; i < players.Length; i++)
            {
                eldestPlayer = eldestPlayer.WhoIsElder(players[i]);
            }
            Console.WriteLine("The eldest player details are: ");
            eldestPlayer.DisplayPlayerDetails();

            //Program.DisplayPlayerDetails(player1);
            //Program.DisplayPlayerDetails(player2);
            //Program.DisplayPlayerDetails(player3);
            //Program.DisplayPlayerDetails(player4);
            //Program.DisplayPlayerDetails(player5);

            //Player eldestGetPlayer = player1.WhoIsElder(player2);
        }

        

        
    }
}

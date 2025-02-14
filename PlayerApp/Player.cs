using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    public class Player
    {
        private int PlayerId {  get; set; }
        private string PlayerName { get; set; }
        private int PlayerAge { get; set; }

        public Player(int playerId, string playerName, int playerAge) : this(playerId, playerName)
        { 
            PlayerAge = playerAge;
        }
        public Player(int playerId, string playerName) 
        {
            PlayerId = playerId;
            PlayerName = playerName;
            PlayerAge = 20; //default age setting
        }

        public int GetPlayerId()
        {
            return this.PlayerId;
        }
        public string GetPlayerName()
        {
            return this.PlayerName;
        }
        public int GetPlayerAge()
        {
            return this.PlayerAge; 
        }
        public void DisplayPlayerDetails()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Player Id: {GetPlayerId()}");
            Console.WriteLine($"Player Name: {GetPlayerName()}");
            Console.WriteLine($"Player Age: {GetPlayerAge()}");
            Console.WriteLine(" ");
        }
        public Player WhoIsElder(Player player)
        {
            return (this.PlayerAge > player.PlayerAge) ? this : player;
        }
    }
}

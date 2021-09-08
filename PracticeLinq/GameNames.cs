using System;
namespace PracticeLinq
{
    public class GameNames
    {
        public GameNames()
        {
        }

        public GameNames(string games, string[] gameNames)
        {
            Games = games;
            this.gameNames = gameNames;
        }

        public string Games { get; set; }

               
        public string[] gameNames = new string[] { "Mortal Kombat", "Soul Caliber", "D.O.A", "Halo", "Ninja Gaiden" };
        
    }
}

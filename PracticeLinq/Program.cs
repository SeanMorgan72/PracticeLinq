using System;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new GameNames();

            var show = games.gameNames.OrderBy(k => k.Length);

            foreach(var name in show)
            {
                Console.WriteLine(name);
            }
        }
    }
}

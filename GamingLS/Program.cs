using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("***** Gaming Console *****");

            var game = new DropCardGame(); // Any Type of Game can be instantiated and Started..

            game.StartGame();


            Console.WriteLine("****** End Game ******");

           
        }
    }
}

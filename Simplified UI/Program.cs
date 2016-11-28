using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Simplified_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.run();
        }

        public void run()
        {
            Character player = new Character();

            Console.WriteLine(player.calcFavoring(int.Parse(Console.ReadLine())));
            Console.WriteLine();
        }
    }
}

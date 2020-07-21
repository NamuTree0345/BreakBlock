using System;
using Test.GUICont;

namespace Test
{
    class Program
    {
        

        static void Main(string[] args)
        {
            References rf = new References();

            /*
            Console.Clear();
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine(rf.drawTextOnBox("SPACE GAME"));
            Console.WriteLine(rf.drawTextOnBox(""));
            Console.WriteLine(rf.drawTextOnBox("This is Space Game."));
            Console.WriteLine(rf.drawTextOnBox(""));
            Console.WriteLine(rf.drawTextOnBox("PRESS ANY KEY."));
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■");*/

            new MainMenu(true, rf);
        }
    }
}

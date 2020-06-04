using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Test.GUICont
{
    class MainMenu
    {
        private References reference;

        public MainMenu(bool clearable, References rf)
        {
            if (clearable) Console.Clear();
            this.reference = rf;
             Console.WriteLine(@" ____  _____  ______          _  ______  _      ____   _____ _  __");
             Console.WriteLine(@"|  _ \|  __ \|  ____|   /\   | |/ /  _ \| |    / __ \ / ____| |/ /");
             Console.WriteLine(@"| |_) | |__) | |__     /  \  | ' /| |_) | |   | |  | | |    | ' / ");
             Console.WriteLine(@"|  _ <|  _  /|  __|   / /\ \ |  < |  _ <| |   | |  | | |    |  <  ");
             Console.WriteLine(@"| |_) | | \ \| |____ / ____ \| . \| |_) | |___| |__| | |____| . \ ");
             Console.WriteLine(@"|____/|_|  \_\______/_/    \_\_|\_\____/|______\____/ \_____|_|\_\");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DEVELOPER: NamuTree0345");
            Console.WriteLine("GITHUB: NamuTree0345/BreakBlock");
            Console.WriteLine();
            Console.WriteLine("■■■■■■■■■■■■■■■■■");
            Console.WriteLine("■             GAME MENU        ■");
            Console.WriteLine("■                              ■");
            Console.WriteLine("■     (G)ithub  (S)tart        ■");
            Console.WriteLine("■        S(e)tting  E(x)it     ■");
            Console.WriteLine("■■■■■■■■■■■■■■■■■");
            //end();

            bool shouldClose = false;

            do
            {
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo keys = Console.ReadKey(true);
                    switch (keys.Key) {
                        case ConsoleKey.G:
                            Process.Start("http://github.com/NamuTree0345/BreakBlock");
                            break;
                        case ConsoleKey.S:
                            new GameMain(rf);
                            break;
                        case ConsoleKey.E:
                            Console.WriteLine("This is Developing...");
                            Thread.Sleep(1000);
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.X:
                            Console.WriteLine("Bye");
                            Thread.Sleep(1000);
                            Environment.Exit(0);
                            break;

                    }
                }
            } while (!shouldClose);

        }

        private void writeText(string text)
        {
            //Console.WriteLine(reference.drawTextOnBox(text));
            Console.WriteLine(text);
        }

        private void end()
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■");
        }
    }
}

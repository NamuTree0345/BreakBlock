using System;
using System.Collections.Generic;
using System.Text;

namespace Test.GUICont
{
    class MainMenu
    {
        private References reference;

        public MainMenu(bool clearable, References rf)
        {
            if (clearable) Console.Clear();
            this.reference = rf;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■");
            writeText("this is a game");
            writeText("");
            writeText("SPACE키: 블록부수기");
            writeText("");
            writeText("ctrl+c to close");
            writeText("PRESS ANY KEY");
            end();

            bool shouldClose = false;

            do
            {
                if (Console.KeyAvailable) {
                    Console.Clear();
                    Console.WriteLine("ok");
                    new GameMain(rf);
                    shouldClose = true;
                }
            } while (!shouldClose);

        }

        private void writeText(string text)
        {
            Console.WriteLine(reference.drawTextOnBox(text));
        }

        private void end()
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Test.GUICont
{
    class GameSelect
    {
        private References reference;

        public GameSelect(bool clearable, References rf)
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
            Console.WriteLine("■■■■■■■■■■■■■■■■■");
            Console.WriteLine("■          GAME SELECT         ■");
            Console.WriteLine("■■■■■■■■■■■■■■■■■");
            Console.WriteLine();
            Console.Write("총 어템수: ");
            var att = Console.ReadLine();
            try
            {
                Console.WriteLine();
                int attnum = int.Parse(att);

                Console.WriteLine();
                Console.WriteLine("1초: 1000밀리초");
                Console.WriteLine("속도는 100을 권장합니다.");
                Console.Write("속도(밀리초): ");
                var speed = Console.ReadLine();

                int speednum = int.Parse(speed);
                new GameMain(rf, attnum, speednum);
            }
            catch (FormatException) {
                Console.WriteLine("어템수 또는 속도는 정수로만 써야됩니다.");
                Console.WriteLine("잠시 후 메인화면으로 돌아갑니다.");
                Thread.Sleep(1000);
                new MainMenu(true, rf);
            }
            //end();



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

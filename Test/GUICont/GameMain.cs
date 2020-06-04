using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Test.Util;

namespace Test.GUICont
{
    class GameMain
    {

        private int score = 0;

        public GameMain(References rf)
        {
            // i = 블럭 Y좌표
            for (int f = 0; f < 30; f++)
            {
                Console.Clear();
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    Console.Clear();
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = Util.Util.randomConsoleColor();
                    Console.WriteLine(rf.fillrec);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keys = Console.ReadKey(true);
                        if (keys.Key == ConsoleKey.Spacebar)
                        {
                            //Console.WriteLine(i);
                            if (i == Console.WindowHeight - 1)
                            {
                                Console.WriteLine("잘했어요!");
                                Console.Beep();
                                Console.ResetColor();
                                score++;
                            }
                            else
                            {
                                Console.Beep();
                                Console.WriteLine("아쉽지만, 실패");
                                Console.WriteLine("점수: " + score);
                                Console.WriteLine("잠시 후 메인 화면으로 이동합니다.");
                                Console.ResetColor();
                                Thread.Sleep(1000);
                                new MainMenu(true, rf);
                            }
                        }
                        



                    }
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
            }
        }
    }
}

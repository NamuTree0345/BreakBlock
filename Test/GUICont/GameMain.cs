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
        private Random r = new Random();

        public GameMain(References rf, int att, int speed)
        {
            // i = 블럭 Y좌표

            // true = 채워진거
            // false = 빈거
            bool[] xBlocks = new bool[Console.WindowWidth];

            // att번만큼 떨어지는거 반복
            for (int f = 0; f < att; f++)
            {
                // 떨어질때마다 콘솔 지우기
                Console.Clear();
                Console.Write("현재 점수: " + score);
                // 떨어지기
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    Console.Clear();
                    for (int j = 0; j < i; j++)
                    {
                        // 빈칸 여러개를 넣어서 아래에 있게 하기(?)
                        Console.WriteLine();
                    }
                    // x값 계산
                    for (int x = 0; x < xBlocks.Length; x++) {
                        bool value;

                        switch (r.Next(0, 2)) {
                            case 0:
                                value = true;
                                break;
                            case 1:
                                value = false;
                                break;
                   
                            default:
                                value = false;
                                break;
                        }
                        
                        xBlocks[x] = value;
                    }
                    char[] chars = new char[xBlocks.Length];
                    for (int b = 0; b < chars.Length; b++) {
                        if (xBlocks[b] == false)
                        {
                            chars[b] = ' ';
                        }
                        else {
                            chars[b] = '■';
                        }
                    }
                    // 채워진 사각형 그리기
                    Console.ForegroundColor = Util.Util.randomConsoleColor();
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string(chars));
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
                    Thread.Sleep(speed);
                }
                Thread.Sleep(100);
            }
            Console.WriteLine("최종점수: " + score);
            Console.WriteLine("잠시 후 메인 화면으로 돌아갑니다.");
            Thread.Sleep(1000);
            new MainMenu(true, rf);
        }
    }
}

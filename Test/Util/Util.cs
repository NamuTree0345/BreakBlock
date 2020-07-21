using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Util
{
    class Util
    {
        internal static ConsoleColor randomConsoleColor()
        {
            switch (new Random().Next(1, 5)) {
                case 1:
                    return ConsoleColor.Red;
                    break;
                case 2:
                    return ConsoleColor.Green;
                    break;
                case 3:
                    return ConsoleColor.Yellow;
                    break;
                case 4:
                    return ConsoleColor.Blue;
                    break;
                case 5:
                    return ConsoleColor.Cyan;
                    break;
                default:
                    return ConsoleColor.Magenta;
                    break;
            }
        }
    }
}

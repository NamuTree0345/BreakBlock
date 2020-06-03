using System;
using System.Collections.Generic;
using System.Text;

namespace Test.GUI
{
    class GUI
    {

        private References reference;

        public GUI(bool clearable, References rf) {
            if(clearable) Console.Clear();
            this.reference = rf;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■");
        }

        private void writeText(string text) {
            Console.WriteLine(reference.drawTextOnBox(text));
        }

        private void end()
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■");
        }

    }
}

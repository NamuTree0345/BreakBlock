using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class References
    {

        public string fillrec = "■";
        public string rec = "□";
        public string circle = "○";
        public string fillcircle = "●";
        public int BorderUpDownLen = 22;

        public string drawTextOnBox(string msg)
        {
            string result = "";

            // ■        msg        ■
            // ■   hello world!!   ㅁ
            // MK
            // ■                   a                    ■
            // ■                   b                    ■
            // ■                cdf                 ■
            // Space x20
            string spaces = "                    ";
            if (msg.Length == 1) {
                result = this.fillrec + spaces + msg + spaces + this.fillrec;
                return result;
            }

            int spaceNum = 20 - msg.Length;
            List<char> spaceList = new List<char>();

            for (int i = 0; i < spaceNum; i++) {
                spaceList.Add(' ');
            }

            string spaceString = new string(spaceList.ToArray());

            result = this.fillrec + spaces + msg + spaceString + this.fillrec;

            return result;
        }

    }
}

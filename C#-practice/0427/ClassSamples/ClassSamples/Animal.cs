using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSamples
{
    internal class Animal
    {
        public string name = "";//名前
        public string color = "";//色
        public string Sing()
        {
            string resultString = "";
            if (name == "Cat ネコ")
            {
                resultString = "Meow-Meow にゃー！";
            }
            else if (name == "Dog イヌ")
            {
                resultString = "Bow-Wow わん！";
            }
            else 
            {
                resultString = "？";
            }
            return resultString;
        }
    }
}

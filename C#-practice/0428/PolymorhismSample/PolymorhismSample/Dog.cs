using PolymorhismSample.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorhismSample
{
    internal class Dog : Animal//Animalクラスを継承
    {
        public string? Nose { get; set; } = "丸";    //花の形

        public override Image Sing()
        {
            return Resources.DogCookieSing;
        }
        public override Image Reset()
        {
            return Resources.DogCookie;
        }
    }
}

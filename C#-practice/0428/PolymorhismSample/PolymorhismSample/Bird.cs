using PolymorhismSample.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorhismSample
{
    internal class Bird: Animal //Anima継承
    {
        public string? Beak { get; set; } = "三角";   //くちばしの形

        public override Image Sing()
        {
            return Resources.BirdCookieSing;
        }
        public override Image Reset()
        {
            return Resources.BirdCookie;
        }
    }
}

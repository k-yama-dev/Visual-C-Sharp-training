using PolymorhismSample.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorhismSample
{
    internal class Cat: Animal //Animal継承
    {
        public string? Ear { get; set; } = "丸"; //耳の形

        public override Image Sing()
        {
            return Resources.CatCookieSing;
        }
        public override Image Reset()
        {
            return Resources.CatCookie;
        }
    }

}

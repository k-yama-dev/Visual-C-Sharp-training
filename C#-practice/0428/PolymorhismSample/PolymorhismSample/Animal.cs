using PolymorhismSample.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorhismSample
{
    internal class Animal
    {
        //すべての動物クッキーに共通している値を定義します
        public string? Color { get; set; } = "茶";
        public string? Smell { get; set; } = "コーヒー";
        public string? Flavor { get; set; } = "チョコレート";

        //動物の鳴き声
        public virtual Image Sing()
        {
            return Resources.AnimalCookieSing;
        }

        public virtual Image Reset()
        {
            return Resources.AnimalCookie;
        }
    }
}

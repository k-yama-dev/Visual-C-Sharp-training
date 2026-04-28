using PolymorhismSample.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorhismSample
{
    internal abstract class Animal
    {
        //すべての動物クッキーに共通している値を定義します
        public string? Color { get; set; } = "茶";
        public string? Smell { get; set; } = "コーヒー";
        public string? Flavor { get; set; } = "チョコレート";

        //動物の鳴き声
        public abstract Image Sing();

        public abstract Image Reset();
       
    }
}

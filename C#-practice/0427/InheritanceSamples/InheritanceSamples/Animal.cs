using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSamples
{
    //Animalクラスです
    internal class Animal
    {
        public string? Color {  get; set; } //色のプロパティ
        public string? Smell{ get; set; } //匂いのプロパティ
        public string? Flavor {  get; set; } //味のプロパティ
        //動物の鳴き声
        public string Sing()
        {
            return "・・・";
        }
    }   
}

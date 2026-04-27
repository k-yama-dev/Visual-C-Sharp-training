using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSamples
{
    //Animalクラスを継承したCatクラス
    internal class Cat:Animal
    {
        //Animalクラスで定義されていない部分だけを記述
        public string? Ear {  get; set; } //耳の形のプロパティ

        //Catクラス独自のメソッドも追加できる
        public string CatSing()
        {
            return "にゃー！";
        }
    }
}

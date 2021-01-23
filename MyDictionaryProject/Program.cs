using System;
using System.Collections.Generic;

namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(1, "Ankara");
            sehirler.Add(31, "Hatay");
            sehirler.Add(46, "Kahramanmaraş");
            sehirler.Yazdir(0);
            sehirler.Yazdir(1);
            sehirler.Yazdir(2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryProject
{
    class MyDictionary<K,V>
    {
        K[] anahtarlar;
        V[] degerler;

        public MyDictionary()
        {
            anahtarlar = new K[0];
            degerler = new V[0];
        }
        public void Add(K anahtar, V deger)
        {
            K[] tempanahtarlar = anahtarlar;
            V[] tempdeğerler = degerler ;
            anahtarlar = new K[anahtarlar.Length + 1];
            degerler = new V[degerler.Length + 1];
            for (int i = 0; i < tempanahtarlar.Length; i++)
            {
                anahtarlar[i] = tempanahtarlar[i];
                degerler[i] = tempdeğerler[i]; 
            }
            anahtarlar[anahtarlar.Length - 1] = anahtar;
            degerler[degerler.Length - 1] = deger;

        }
        public void Yazdir(int a)
        {
            Console.WriteLine(anahtarlar[a]+"   "+ degerler[a]);
        }
    }
}

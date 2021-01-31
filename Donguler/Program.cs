using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurlar1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurlar2 = "Programlamaya başlangıç için Temel Program";
            string kurlar3 = "java";
            //array-dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için Temel Program", "java","python","C#" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonn");
            foreach (string  kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");
        }
    }
}

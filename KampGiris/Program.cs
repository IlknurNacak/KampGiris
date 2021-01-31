using System;

namespace KampGiris
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string kategoriEtiketi = "kategori"; //kategoriEtiket değer tutucu , alias.
            int ogrenciSayisi = 3200;
            bool sistemeGirişYapmısMi= false ;//C# bool ile tanımlarız javada ise boolean .
            double dolarDun= 7.35;
            double dolarBugun = 7.36;
            //iften sonra tab a 2 kere basınca otomatik tamamlar.
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)

            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            if (sistemeGirişYapmısMi==true)
            {
                Console.WriteLine("kullanıcı ayarı butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);//Ekrana yazı yazmamızı sağlar.(print) line=satır.


        }
    }
}

using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 11;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1,urun2};
            //type-safe --- tip güvenliği 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------------Metotlar-----------------");

            //instance-örnek
            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(urun2);
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun1); 
            sepetManeger.Ekle(urun2); 
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle2("armut", "yeşil armut", 12);
            sepetManeger.Ekle2("elma", "yeşil armut", 12);
            sepetManeger.Ekle2("karpuz", "yeşil armut", 12);
            sepetManeger.Ekle2("kiraz", "yeşil armut", 12);
        }
    }
}

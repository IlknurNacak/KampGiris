using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ilknur";
            int yas = 21;
            Kurs kurs1 = new Kurs();//tanımladık 9 ve 10 satırda yaptığımız gibi .
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.İzlenmeSayisi = 68;
            kurs2.KursAdi = "C";
            kurs2.Egitmen = "burak";
            kurs2.İzlenmeSayisi = 152;

            kurs3.KursAdi = "java";
            kurs3.Egitmen = "ilknur";
            kurs3.İzlenmeSayisi = 1168;
            //  Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " " + kurs.Egitmen+" "+ kurs.İzlenmeSayisi);
            }
            
        }
    }

    class Kurs
    {
        //prop yaz iki kere tab a bas
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeSayisi { get; set; }
    }
}

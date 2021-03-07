using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
            string[] meyveler = new string[] { };


            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            Product[] products = new Product[] { urun1, urun2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------");

            }

            Console.WriteLine("----------Metotlar----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut", "yeişl armut", 12);
            sepetManager.Ekle2("elma", "yeişl elma", 12);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12);

        }
    }
}

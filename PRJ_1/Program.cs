using System;

namespace PRJ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Etek";
            urun1.Marka = "Koton";
            urun1.Fiyat = 95;
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Çanta";
            urun2.Marka = "Mango";
            urun2.Fiyat = 250;
            urun2.StokAdedi = 50;

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürünün Adı: " + urun.UrunAdi);
                Console.WriteLine("Ürünün Açıklaması: " + urun.Marka);
                Console.WriteLine("Ürünün Fiyatı: " + urun.Fiyat);
                Console.WriteLine("Ürünün Stok Adedi: " + urun.StokAdedi);
                Console.WriteLine("-------------------------------------------------------------------");
            }

            Console.WriteLine("--------------------------Metotlar----------------------------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
        }
    }
}

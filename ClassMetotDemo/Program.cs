using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Kaan";
            musteri1.Soyadi = "Durmaz";
            musteri1.TelNo = 22346;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Tolga";
            musteri2.Soyadi = "Gündüz";
            musteri2.TelNo = 78609;

            Musteri musteriekle = new Musteri();
            List<Musteri> musteris = new List<Musteri>() { musteri1, musteri2, musteriekle };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteriekle);
            musteriManager.Delete(musteri1);
            musteriManager.Listele(musteris);

        }
    }
}

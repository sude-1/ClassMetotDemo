using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            musteri.Adi = "Sude";
            musteri.Soyadi = "Karanlık";
            musteri.Id = 3;
            musteri.TelNo = 765689;
            Console.WriteLine(musteri.Adi +" "+ musteri.Soyadi+ " " +"Müşteri Eklendi");
        }

        public void Delete(Musteri musteri1)
        {
            Console.WriteLine(musteri1.Adi +" "+musteri1.Soyadi + " " + "Müşteri Silindi");
        }

        public void Listele(List<Musteri> musteris)
        {
            foreach (var musterim in musteris)
            {
                Console.WriteLine(musterim.Adi + " " + musterim.Soyadi + " " + "Müşteriler Listelendi");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri eklendi.");
            Console.WriteLine("");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi:");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
            Console.WriteLine("");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri silindi.");
            Console.WriteLine("");
        }
        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri güncellendi.");
        }
    }
}

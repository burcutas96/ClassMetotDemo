
using ClassMetotDemo;

MusteriManager musteriManager = new MusteriManager();

Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Ad = "Burcu";
musteri1.Soyad = "Taş";
musteri1.Cinsiyet = "Kız";

Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Ad = "Engin";
musteri2.Soyad = "Demiroğ";
musteri2.Cinsiyet = "Erkek";

Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.Ad = "Enes";
musteri3.Soyad = "Bayram";
musteri3.Cinsiyet = "Erkek";

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

musteriManager.MusteriEkle(musteri1);
musteriManager.MusteriListele(musteriler);
musteriManager.MusteriSilme(musteri3);
musteriManager.MusteriGuncelle(musteri2);

Console.ReadLine();


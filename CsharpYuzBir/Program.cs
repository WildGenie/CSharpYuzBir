using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpYuzBir
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kitap Ad: Çalıkuşu");
            //Console.WriteLine("Yazar: Reşat Nuri");
            //Console.WriteLine("Tür: Roman");

            //string cumle, cumle2;
            //cumle = "Bugün Tarih 7 Kasım 2018";
            //cumle2 = "Bu gün hava sıcak";
            //Console.Write(cumle + " " + cumle2);

            //int sayi = 24;
            //Console.Write(sayi);

            //int sayi1, sayi2, sonuc;
            //sayi1 = 20;
            //sayi2 = 30;
            //sonuc = sayi1 + sayi2;
            //Console.Write(sonuc);

            //string sehir;
            //Console.Write("Lütfen şehri giriniz: ");
            //sehir = Console.ReadLine();
            //Console.Write(sehir);

            //string ograd, ogrsoyad, numara;
            //Console.Write("Adınız: ");
            //ograd = Console.ReadLine();
            //Console.Write("Soyadınız: ");
            //ogrsoyad = Console.ReadLine();
            //Console.Write("Numara: ");
            //numara = Console.ReadLine();
            //Console.Write("Öğrenci Bilgileri: " + ograd + " " + ogrsoyad + " " + numara);

            //int sayi1, sayi2, toplam;
            //Console.Write("Sayı 1: ");
            //sayi1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sayı 2: ");
            //sayi2 = Convert.ToInt16(Console.ReadLine());
            //toplam = sayi1 + sayi2;
            //Console.Write(toplam);

            //Console.Write("Şifreniz: ");
            //string sifre = Console.ReadLine();
            //if (sifre == "1234")
            //{
            //    Console.Write("Giriş Başarılı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Giriş");
            //}

            //// Mod Alma %
            //Console.Write("Sayıyı Giriniz: ");
            //int sayi = Convert.ToInt16(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.Write("Çift");
            //}
            //else
            //{
            //    Console.Write("Tek");
            //}

            //// Soru: Klavyeden girilen 3 basamaklı sayının 
            //// basamakları toplamını hesaplayan kodu yazınız.

            //Console.Write("Üç Basamaklı Bir Sayı Giriniz: ");
            //int sayi = Convert.ToInt16(Console.ReadLine());
            //int birler = sayi % 10;
            //int onlar = (sayi / 10) % 10;
            //int yuzler = (sayi / 100) % 10;
            //int sayilartoplami = birler + onlar + yuzler;
            //Console.Write("Rakamlar Toplami: " + sayilartoplami);

            //// Soru: Klavyeden iki not girildiğinde ikisinin ortalamasını hesaplayıp
            //// 50'den büyük ve eşitse geçti, küçükse kaldı yazdıran kodu yazınız.

            //int not1, not2, ortalama;
            //Console.Write("Sınav 1: ");
            //not1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //not2 = Convert.ToInt16(Console.ReadLine());
            //ortalama = (not1 + not2) / 2;
            //Console.Write("Ortalamanız: " + ortalama);
            //if (ortalama >= 50)
            //{
            //    Console.Write(" Geçtiniz");
            //}
            //else
            //{
            //    Console.Write(" Kaldınız");
            //}

            //Console.Write("Sicaklığı giriniz: ");
            //int sicaklik = Convert.ToInt16(Console.ReadLine());
            //if (sicaklik <= 0)
            //{
            //    Console.Write("Katı");
            //}
            //if (sicaklik > 0 && sicaklik < 100)
            //{
            //    Console.Write("Sıvı");
            //}
            //if (sicaklik >= 100)
            //{
            //    Console.Write("Gaz");
            //}

            //// 1 ile 20 arasında %10
            //// 21 ile 40 arasında %20
            //// 40 ve üstü %30 indirim

            //int kitap;
            //double tutar;
            //Console.Write("Alınan kitap sayısını giriniz: ");
            //kitap = Convert.ToInt16(Console.ReadLine());
            //if (kitap >= 1 && kitap <= 20)
            //{
            //    tutar = (kitap * 8) - (kitap * 8 * 0.1);
            //    Console.Write(tutar);
            //}
            //if (kitap >= 21 && kitap <= 40)
            //{
            //    tutar = (kitap * 8) - (kitap * 8 * 0.2);
            //    Console.Write(tutar);
            //}
            //if (kitap >= 41)
            //{
            //    tutar = (kitap * 8) - (kitap * 8 * 0.3);
            //    Console.Write(tutar);
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine(toplam);

            // Soru: bir bakteri türü her saatin sonunda kendini 2'ye bölerek
            // çoğalmaktadır. Yeni oluşan bakteriler de aynı şekilde
            // ikiye bölünerek artıyorlar. Buna göre 24 saatin sonunda
            // bu ortamda kaç tane bakteri olur.

            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri = bakteri * 2;
            //}
            //Console.WriteLine(bakteri);

            //int a = 1, b = 1, c;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //for (int i = 1; i <= 8; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;
            //    Console.WriteLine(c);
            //}

            int sayi = 1;
            int toplam = 0;
            while (sayi <= 10)
            {
                //Console.WriteLine(sayi);
                toplam = toplam + sayi;
                sayi++;
            }
            Console.WriteLine(sayi);

            Console.Read();
        }
    }
}

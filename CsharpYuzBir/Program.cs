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
            //toplam = sayi1 * sayi2;
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

            // Mod Alma %
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

            // Soru: Klavyeden girilen 3 basamaklı sayının 
            // basamakları toplamını hesaplayan kodu yazınız.

            Console.Write("Üç Basamaklı Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = (sayi / 10) % 10;
            int yuzler = (sayi / 100) % 10;
            int sayilartoplami = birler + onlar + yuzler;
            Console.Write("Rakamlar Toplami: " + sayilartoplami);

            Console.Read();
        }
    }
}

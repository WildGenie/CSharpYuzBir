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

            string ograd, ogrsoyad, numara;
            Console.Write("Adınız: ");
            ograd = Console.ReadLine();
            Console.Write("Soyadınız: ");
            ogrsoyad = Console.ReadLine();
            Console.Write("Numara: ");
            numara = Console.ReadLine();
            Console.Write("Öğrenci Bilgileri: " + ograd + " " + ogrsoyad + " " + numara);

            Console.Read();
        }
    }
}

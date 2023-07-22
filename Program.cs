using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("C# Operatorlar");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(" * == eşit\r\n * <= küçük eşit\r\n * >= büyük eşit\r\n * != eşit degil\r\n * && ve\r\n * || veya ");

            
            Console.WriteLine("---------------------------------------------------");



            Console.WriteLine("Öğrenci Adı Programı");
            Console.WriteLine("-----------------------------------------------------");

            string ad;
            Console.WriteLine("Öğrencinin İsmini Giriniz : ");

            ad = Console.ReadLine();

            if (ad == "Emcet Hazani")
            {
                Console.WriteLine("Girdiğiniz İsim " + ad);
            }
            else if (ad == "Mühendis")
            {
                Console.WriteLine("Girdiğiniz İsim " + ad);
            }
            else
            {
                Console.WriteLine("Hatalı İsim");
            }



            Console.WriteLine("-----------------------------------------------------");


            Console.WriteLine("1.Vize + 2.Vize ve Finel Hesablama Programı");
            Console.WriteLine("-----------------------------------------------------");

            int vize_1, vize_2, finel, vize_ortalama, finel_ortalama, sonucu;

            Console.Write("1.vize : ");
            vize_1 = int.Parse(Console.ReadLine());
            Console.Write("2.vize : ");
            vize_2 = int.Parse(Console.ReadLine());
            Console.Write("finel : ");
            finel = int.Parse(Console.ReadLine());

            vize_ortalama = (vize_1 + vize_2) * 40 / 100 ;
            finel_ortalama = (finel * 60 / 100);
            sonucu = (vize_ortalama + finel_ortalama) ;


            if (sonucu >= 50 && vize_ortalama >= 0 && finel_ortalama >= 0 && vize_ortalama <= 100 && finel_ortalama <= 100)
            {
                Console.WriteLine("Tebrikler. Dersten geçtiniz. Ortalamanız ^_^ : " + sonucu);
            }
            else if (sonucu < 50 && vize_ortalama >= 0 && finel_ortalama >= 0 && vize_ortalama <= 100 && finel_ortalama <= 100)
            {
                Console.WriteLine("Üzgünüm. Dersten kaldınız. Ortalamanız '_' : " + sonucu);
            }
            else
            {
                Console.WriteLine("Sınav notları negatif ve 100den büyük değer alamaz!!!");
            }



            Console.WriteLine("----------------------------------------------------------------");



            Console.WriteLine("Vize ve Finel Hesablama Programı");
            Console.WriteLine("-----------------------------------------------------");

            double vize, final, ort;

            Console.Write("Vize Notu Giriniz : ");
            vize = double.Parse(Console.ReadLine());
            Console.Write("Final Notu Giriniz : ");
            final = double.Parse(Console.ReadLine());

            vize = (vize * 40 / 100);
            final = (final * 60 / 100);
            ort = (vize + final);


            if (ort < 50 && vize <= 100 && final <= 100 && vize > 0 && final > 0)
            {
                Console.WriteLine("Dersten kaldınız '_' : " + ort);
            }
            else if (ort >= 50 && vize <= 100 && final <= 100 && vize > 0 && final > 0)
            {
                Console.WriteLine("Dersten geçtiniz ^_^: " + ort);
            }
            else
            {
                Console.WriteLine("Vize ve Final Notları 0-100 arasında olmak zorundadır.");
            }

 
            Console.WriteLine("----------------------------------------------------------");


            Console.WriteLine("Sayinin Tek i Çift mi Programı");
            Console.WriteLine("-----------------------------------------------------");

            int sayi;
            Console.Write("Lütfen Bir Sayi Giriniz : ");
            sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiniz Sayı Çifttir ^_^");
            }
            else
            {
                Console.WriteLine("Girdiniz Sayı Tektir ^_^");
            }

            Console.ReadKey();

        }
    }
}

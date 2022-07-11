using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            repeat2:
            try
            {
                
                Console.WriteLine("HESAP MAKİNESİ İŞLEMİNE HOŞGELDİNİZ :)");
                repeat:
                Console.WriteLine("DEVAM ETMEK İÇİN D, BİTİRMEK İÇİN B HARFİNİ TUŞLAYINIZ");
                string enter = Console.ReadLine().ToUpper();
                if (enter == "D") { }
                else if (enter == "B")
                {
                    Environment.Exit(0);
                }
                else if (enter != "D" || enter != "B")
                {
                    Console.WriteLine("YANLIŞ TUŞLADINIZ TEKRAR DENEYİN...");
                    goto repeat;
                }
                Console.WriteLine("İŞLEMİNİZİ YAPABİLİRSİNİZ...\nSırayla sayıları giriniz...");
                double sayi1 = Convert.ToInt32(Console.ReadLine());
                double sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İlk Değer : {0} İkinci Değer : {1}",sayi1,sayi2 );
                double sonuc;

                tekrar:
                Console.WriteLine("YAPMAK İSTEDİĞİNİZ MATEMATİKSEL İŞLEMİ SEÇİNİZ...\n+ , - , / , *");
                string yapilanIslem = Console.ReadLine();
                if (yapilanIslem == "+" || yapilanIslem == "-" || yapilanIslem == "*" || yapilanIslem == "/")
                {
                    Console.WriteLine("HESAPLANIYOR....");
                }
                else
                {
                    Console.WriteLine("YANLIŞ TUŞA BASTINIZ...");
                    goto tekrar;
                }

                switch (yapilanIslem)
                {
                    case "+":
                        sonuc = (sayi1) + (sayi2);
                        Console.WriteLine("({0})+({1})={2}",sayi1,sayi2,sonuc);
                        break;
                    case "-":
                        sonuc = (sayi1) - (sayi2);
                        Console.WriteLine("({0})-({1})={2}", sayi1, sayi2, sonuc);
                        break;
                    case "*":
                        sonuc = (sayi1) * (sayi2);
                        Console.WriteLine("({0})*({1})={2}", sayi1, sayi2, sonuc);
                        break;
                    case "/":
                        sonuc = (sayi1) / (sayi2);
                        Console.WriteLine("({0})({1})={2}", sayi1, sayi2, sonuc);
                        break;
                }
                goto repeat;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto repeat2;
            }

            Console.ReadLine();


        }
    }
}

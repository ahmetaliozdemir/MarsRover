using Mars;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plato x konum sınırını giriniz: ");
            int xlimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plato y konum sınırını giriniz: ");
            int ylimit = Convert.ToInt32(Console.ReadLine());
            Plato plato = new Plato(xlimit, ylimit);


            Console.WriteLine("Kaç tane gezici var ?");
            int geziciSayisi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < geziciSayisi; i++)
            {
                Console.WriteLine("X konumunu giriniz :");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y konumunu giriniz :");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yönünü giriniz (N,E,W,S) :");
                char yon = Convert.ToChar(Convert.ToString(Console.ReadLine()).ToUpper());
                plato.GeziciEkle(x, y, yon);
            }

            int gezicisayisi = plato.GeziciSayisi();

            for (int i = 0; i < gezicisayisi; i++)
            {
                
                bool durum = true;
                string gezicikonum = "";

                while (durum)
                {
                    Console.WriteLine("Gezici hareketlerine devam etmek istiyormusunuz ? (y/n)");
                    string devam = Console.ReadLine();
                    bool cevap = devam == "y" ? true : false;
                    if (cevap)
                    {
                        Console.WriteLine("İşlemler Right(R),Left(L),Move(M) birini seçebilirsiniz.");
                        char islem = Convert.ToChar(Console.ReadLine());
                        gezicikonum = plato.GeziciHareket(i, islem);
                        Console.WriteLine(gezicikonum);

                    }
                    else
                    {
                        Console.WriteLine("Gezicinin mevcut konumu " + gezicikonum);
                        Console.WriteLine("Bir gezicinin işlemleri tamamlandı.");
                        durum = false;
                        break;
                    }
                }
                

            }

            Console.WriteLine("Başka bir gezici kalmadı işlem bitti.");

            Console.ReadLine();

        }
    }
}

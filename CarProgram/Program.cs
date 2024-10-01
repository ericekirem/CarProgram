using CarProgram;
using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        
        List<Araba> arabalar = new List<Araba>();
        string cevap;

        do
        {
            Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
            cevap = Console.ReadLine()?.ToLower();

            if (cevap == "e")
            {
                Araba yeniAraba = new Araba();

                Console.Write("Seri Numarası: ");
                yeniAraba.SeriNumarasi = Console.ReadLine();

                Console.Write("Marka: ");
                yeniAraba.Marka = Console.ReadLine();

                Console.Write("Model: ");
                yeniAraba.Model = Console.ReadLine();

                Console.Write("Renk: ");
                yeniAraba.Renk = Console.ReadLine();

                // Kapı sayısını alma
                bool kapıSayisiValid = false;
                while (!kapıSayisiValid)
                {
                    Console.Write("Kapı Sayısı: ");
                    string kapıSayisiInput = Console.ReadLine();

                    if (int.TryParse(kapıSayisiInput, out int kapıSayisi))
                    {
                        yeniAraba.KapiSayisi = kapıSayisi;
                        kapıSayisiValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz kapı sayısı. Lütfen sayısal bir değer girin.");
                    }
                }

                arabalar.Add(yeniAraba);
            }
            else if (cevap != "h")
            {
                Console.WriteLine("Geçersiz cevap. Lütfen 'e' veya 'h' girin.");
            }

        } while (cevap != "h");

        // Araba bilgilerini yazdır
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
}

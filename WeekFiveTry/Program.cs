using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                //girdi al
                Console.Write("Lütfen bir sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                int karesi = sayi * sayi;
                //karesini al yazdir
                Console.WriteLine($"Girdiğiniz sayının karesi: {karesi}");
                break; // Geçerli bir sayı girildiğinde döngüden çık
            }
            catch (FormatException)
            //geçersiz girişde tekrar data al
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }
    }
}

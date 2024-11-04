# README.md

## Proje Adı: Kare Hesaplama Uygulaması

Bu uygulama, kullanıcıdan bir tamsayı alır ve bu sayının karesini hesaplayarak ekrana yazdırır. Kullanıcı geçerli bir sayı girene kadar, uygulama hata mesajları vererek tekrar giriş yapmasını ister.

### Özellikler

- Kullanıcıdan giriş almak.
- Geçerli bir tamsayı girilene kadar hata kontrolü yapmak.
- Girilen sayının karesini hesaplayarak ekrana yazdırmak.

### Kullanım

1. Uygulamayı çalıştırın.
2. Konsola bir tamsayı girin.
3. Uygulama, girdiğiniz sayının karesini hesaplayacak ve sonucu gösterecektir.
4. Geçersiz bir girdi girerseniz, uygulama hata mesajı verecek ve tekrar sayı girmenizi isteyecektir.

### Gereksinimler

- .NET Framework (veya .NET Core)
- C# derleyicisi

### Kod Açıklaması

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                // Girdi al
                Console.Write("Lütfen bir sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                int karesi = sayi * sayi;
                
                // Karesini al yazdır
                Console.WriteLine($"Girdiğiniz sayının karesi: {karesi}");
                break; // Geçerli bir sayı girildiğinde döngüden çık
            }
            catch (FormatException)
            {
                // Geçersiz girişte tekrar data al
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }
    }
}
```

### Hata Yönetimi

- Uygulama, kullanıcıdan alınan girdi geçersiz olduğunda (örneğin, harf veya özel karakterler girildiğinde) `FormatException` yakalar ve kullanıcıyı bilgilendirir.

### Katkıda Bulunanlar

- [Adınızı Ekleyin]

### Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasına bakın.
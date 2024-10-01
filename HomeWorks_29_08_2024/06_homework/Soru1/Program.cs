namespace Soru1;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int toplam = 0;
        int adet = 0;

        for (int i = 1; i <= sayi; i++)
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                toplam += i;
                adet++;
            }
        }

        if (adet > 0)
        {
            double ortalama = (double)toplam / adet;
            Console.WriteLine($"Ortalama: {ortalama}");
        }
        else
        {
            Console.WriteLine("Bu aralıkta 3'ün ve 4'ün katı olan sayı yok.");
        }
    }
}
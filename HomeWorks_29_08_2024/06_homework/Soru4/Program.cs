namespace Soru4;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;
        Console.WriteLine("Çarpanlar:");

        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                Console.WriteLine(i);
                toplam += i;
            }
        }

        Console.WriteLine($"Çarpanların toplamı: {toplam}");
    }
}
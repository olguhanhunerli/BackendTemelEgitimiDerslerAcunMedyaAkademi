namespace Soru7;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;

        for (int i = 1; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                toplam += i;
            }
        }

        if (toplam == sayi)
        {
            Console.WriteLine($"{sayi} mükemmel bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} mükemmel bir sayı değildir.");
        }
    }
}
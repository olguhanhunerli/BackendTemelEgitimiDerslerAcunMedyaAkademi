namespace Soru6;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        int bolenSayisi = 0;

        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                bolenSayisi++;
            }
        }

        Console.WriteLine($"Pozitif bölen sayısı: {bolenSayisi}");
    }
}
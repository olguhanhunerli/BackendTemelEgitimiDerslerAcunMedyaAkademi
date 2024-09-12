namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[50];
        Random rastgele = new Random();
        int toplam = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(1, 100);
        }

        foreach (var sayi in dizi)
        {
            if (sayi % 2 == 0)
            {
                toplam += sayi;
            }
        }

        Console.WriteLine($"Çift sayıların toplamı: {toplam}");

    }
}

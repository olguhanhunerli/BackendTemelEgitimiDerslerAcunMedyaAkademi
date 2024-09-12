namespace Soru14;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[20];
        Random rastgele = new Random();
        int toplam = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(1, 100);
        }

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 3 == 0)
            {
                toplam += dizi[i];
            }
            if ((i + 1) % 5 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine($"3'e bölünebilen sayıların toplamı: {toplam}");

    }
}

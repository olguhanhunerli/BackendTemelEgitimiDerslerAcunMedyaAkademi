namespace Soru13;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        Random rastgele = new Random();
        int toplam = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(1, 100);
        }

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                toplam += dizi[i];
            }
        }

        if (toplam % 2 == 0)
        {
            Console.WriteLine($"Toplam: {toplam} - Toplam çift sayı");
        }
        else
        {
            Console.WriteLine($"Toplam: {toplam} - Toplam tek sayı");
        }

    }
}

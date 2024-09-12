namespace Soru17;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        Random rastgele = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(1, 100);
        }

        int enBuyuk = int.MinValue;
        int ikinciEnBuyuk = int.MinValue;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
            }
        }

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > ikinciEnBuyuk && dizi[i] < enBuyuk)
            {
                ikinciEnBuyuk = dizi[i];
            }
        }

        Console.WriteLine("Dizi: " + string.Join(", ", dizi));
        Console.WriteLine($"En büyük sayı: {enBuyuk}");
        Console.WriteLine($"İkinci en büyük sayı: {ikinciEnBuyuk}");

    }
}

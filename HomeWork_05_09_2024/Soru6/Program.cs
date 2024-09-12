namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[100];
        Random rastgele = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(1, 1000);
        }

        int enBuyuk = dizi[0];
        int enKucuk = dizi[0];

        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk) enBuyuk = dizi[i];
            if (dizi[i] < enKucuk) enKucuk = dizi[i];
        }

        Console.WriteLine($"En büyük sayı: {enBuyuk}");
        Console.WriteLine($"En küçük sayı: {enKucuk}");

    }
}

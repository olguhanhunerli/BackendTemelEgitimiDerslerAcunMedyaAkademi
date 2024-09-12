namespace Soru15;

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

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[j] % 2 != 0 && dizi[j] < dizi[i])
                    {
                        int temp = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Dizi (sadece tek sayılar sıralandı): ");
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

    }
}

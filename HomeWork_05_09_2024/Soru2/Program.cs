namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        int[] ciftDizi = new int[10];
        int ciftIndex = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine($"Sayı girin ({i + 1}): ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());

            if (dizi[i] % 2 == 0)
            {
                ciftDizi[ciftIndex++] = dizi[i];
            }
        }

        Array.Resize(ref ciftDizi, ciftIndex);
        Array.Sort(ciftDizi);

        Console.WriteLine("Çift sayılar (küçükten büyüğe sıralı): ");
        foreach (var sayi in ciftDizi)
        {
            Console.WriteLine(sayi);
        }

    }
}

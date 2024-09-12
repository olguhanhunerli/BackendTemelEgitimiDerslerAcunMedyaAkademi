namespace Soru8;

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

        Console.WriteLine("Bir sayı girin: ");
        int aranan = Convert.ToInt32(Console.ReadLine());

        bool bulundu = false;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] == aranan)
            {
                Console.WriteLine($"{aranan} sayısı {i}. indexte bulundu.");
                bulundu = true;
                break;
            }
        }

        if (!bulundu)
        {
            Array.Resize(ref dizi, dizi.Length + 1);
            dizi[dizi.Length - 1] = aranan;
            Array.Sort(dizi);

            Console.WriteLine("Yeni dizi: ");
            foreach (var sayi in dizi)
            {
                Console.WriteLine(sayi);
            }
        }

    }
}

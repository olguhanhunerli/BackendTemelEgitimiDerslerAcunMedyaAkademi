namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        Random rastgele = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(-50, 50);
        }

        int bas = 0, son = dizi.Length - 1;

        while (bas < son)
        {
            if (dizi[bas] > 0 && dizi[son] > 0)
            {
                int temp = dizi[bas];
                dizi[bas] = dizi[son];
                dizi[son] = temp;
                bas++;
                son--;
            }
            else
            {
                if (dizi[bas] <= 0) bas++;
                if (dizi[son] <= 0) son--;
            }
        }

        Console.WriteLine("Pozitif sayılar ters çevrildi: ");
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

    }
}

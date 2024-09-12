namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        int[] tersDizi = new int[10];
        Random rastgele = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(1, 100);
        }

        for (int i = 0; i < dizi.Length; i++)
        {
            tersDizi[dizi.Length - 1 - i] = dizi[i];
        }

        Console.WriteLine("Orijinal dizi: ");
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("Ters dizi: ");
        foreach (var sayi in tersDizi)
        {
            Console.WriteLine(sayi);
        }

    }
}

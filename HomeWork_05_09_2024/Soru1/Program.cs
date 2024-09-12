namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        Random rastgele = new Random();
        for (int i = 0; i < 10; i++)
        {
            dizi[i] = rastgele.Next(1, 100);
        }

        for (int i = 1; i < dizi.Length - 1; i++)
        {
            if (dizi[i - 1] > dizi[i] && dizi[i + 1] > dizi[i])
            {
                Console.WriteLine($"Kriterlere uyan eleman: {dizi[i]}");
            }
        }
     }
}

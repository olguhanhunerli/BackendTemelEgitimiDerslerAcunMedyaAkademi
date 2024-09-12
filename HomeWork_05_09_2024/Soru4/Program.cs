namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[100];
        Random rastgele = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(1, 20);
        }

        for (int i = 0; i < dizi.Length; i++)
        {
            for (int j = i + 1; j < dizi.Length; j++)
            {
                if (dizi[i] == dizi[j])
                {
                    Console.WriteLine($"Sayı {dizi[i]} {i} ve {j}. indexlerde tekrarlandı.");
                }
            }
        }

    }
}

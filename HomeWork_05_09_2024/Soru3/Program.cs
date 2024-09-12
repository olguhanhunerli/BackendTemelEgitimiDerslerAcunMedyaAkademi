namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];
        int[] pozitifDizi = new int[10];
        int[] negatifDizi = new int[10];
        int pozitifIndex = 0, negatifIndex = 0;
        Random rastgele = new Random();

        int index = 0;
        while (index < dizi.Length)
        {
            dizi[index] = rastgele.Next(-100, 100);
            if (dizi[index] > 0)
            {
                pozitifDizi[pozitifIndex++] = dizi[index];
            }
            else if (dizi[index] < 0)
            {
                negatifDizi[negatifIndex++] = dizi[index];
            }
            index++;
        }

        Console.WriteLine("Pozitif sayılar: ");
        for (int i = 0; i < pozitifIndex; i++) Console.WriteLine(pozitifDizi[i]);

        Console.WriteLine("Negatif sayılar: ");
        for (int i = 0; i < negatifIndex; i++) Console.WriteLine(negatifDizi[i]);

    }
}

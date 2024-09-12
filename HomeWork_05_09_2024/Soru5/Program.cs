namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[100];
        Random rastgele = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rastgele.Next(1, 100);
        }

        Console.WriteLine("Bir sayı girin: ");
        int aranan = Convert.ToInt32(Console.ReadLine());

        int tekrarSayisi = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] == aranan)
            {
                Console.WriteLine($"{aranan} sayısı {i}. indexte bulundu.");
                tekrarSayisi++;
            }
        }

        if (tekrarSayisi > 0)
        {
            Console.WriteLine($"{aranan} sayısı {tekrarSayisi} kez tekrarlandı.");
        }
        else
        {
            Console.WriteLine("Sayı dizide bulunamadı.");
        }

    }
}

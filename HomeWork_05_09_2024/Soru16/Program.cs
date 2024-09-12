namespace Soru16;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[100];
        int index = 0;
        int toplam = 0;
        int sayi;

        do
        {
            Console.WriteLine("Bir sayı girin (Çıkmak için 0 girin): ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi != 0)
            {
                dizi[index++] = sayi;
                toplam += sayi;
            }

        } while (sayi != 0);

        Console.WriteLine("Girilen sayılar: ");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(dizi[i]);
        }

        double ortalama = (double)toplam / index;
        Console.WriteLine($"Ortalama: {ortalama}");

    }
}

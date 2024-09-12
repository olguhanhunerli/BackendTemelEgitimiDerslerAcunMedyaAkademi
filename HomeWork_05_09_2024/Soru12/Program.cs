namespace Soru12;

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

        int maxSayi = dizi[0];
        int maxSayiTekrar = 0;

        foreach (var sayi in dizi)
        {
            int tekrarSayisi = 0;
            foreach (var eleman in dizi)
            {
                if (eleman == sayi)
                {
                    tekrarSayisi++;
                }
            }

            if (tekrarSayisi > maxSayiTekrar)
            {
                maxSayi = sayi;
                maxSayiTekrar = tekrarSayisi;
            }
        }

        Console.WriteLine($"En çok tekrar eden sayı: {maxSayi}, {maxSayiTekrar} kez tekrarlandı.");

    }
}

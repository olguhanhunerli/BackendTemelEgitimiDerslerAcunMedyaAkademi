namespace Soru10;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        bool asal = true;

        if (sayi <= 1)
        {
            asal = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asal = false;
                    break;
                }
            }
        }

        if (asal)
        {
            Console.WriteLine($"{sayi} bir asal sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} bir asal sayı değildir.");
        }
    }
}
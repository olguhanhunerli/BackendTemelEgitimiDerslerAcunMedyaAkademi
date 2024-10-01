namespace Soru8;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz (0-6 arası): ");
        int sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 0:
                Console.WriteLine("Nokta");
                break;
            case 1:
                Console.WriteLine("Çizgi");
                break;
            case 2:
                Console.WriteLine("Açı");
                break;
            case 3:
                Console.WriteLine("Üçgen");
                break;
            case 4:
                Console.WriteLine("Kare");
                break;
            case 5:
                Console.WriteLine("Beşgen");
                break;
            case 6:
                Console.WriteLine("Altıgen");
                break;
            default:
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                break;
        }
    }
}
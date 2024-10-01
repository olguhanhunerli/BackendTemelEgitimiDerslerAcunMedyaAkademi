namespace Soru9;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz (1-5 arası): ");
        int sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 1:
                Console.WriteLine("Birinci");
                break;
            case 2:
                Console.WriteLine("İkinci");
                break;
            case 3:
                Console.WriteLine("Üçüncü");
                break;
            case 4:
                Console.WriteLine("Dördüncü");
                break;
            case 5:
                Console.WriteLine("Beşinci");
                break;
            default:
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                break;
        }
    }
}
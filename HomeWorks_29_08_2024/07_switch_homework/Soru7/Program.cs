namespace Soru7;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz (1-5 arası): ");
        int sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 1:
                Console.WriteLine("1 Kr");
                break;
            case 2:
                Console.WriteLine("5 Kr");
                break;
            case 3:
                Console.WriteLine("10 Kr");
                break;
            case 4:
                Console.WriteLine("25 Kr");
                break;
            case 5:
                Console.WriteLine("50 Kr");
                break;
            default:
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                break;
        }
    }
}
namespace Soru1;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz (1-7 arası): ");
        int gun = int.Parse(Console.ReadLine());

        switch (gun)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                break;
        }
    }
}
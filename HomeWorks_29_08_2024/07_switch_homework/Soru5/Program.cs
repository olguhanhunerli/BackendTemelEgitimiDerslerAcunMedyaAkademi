namespace Soru5;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz (1-4 arası): ");
        int mevsim = int.Parse(Console.ReadLine());

        switch (mevsim)
        {
            case 1:
                Console.WriteLine("İlkbahar");
                break;
            case 2:
                Console.WriteLine("Yaz");
                break;
            case 3:
                Console.WriteLine("Sonbahar");
                break;
            case 4:
                Console.WriteLine("Kış");
                break;
            default:
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                break;
        }
    }
}
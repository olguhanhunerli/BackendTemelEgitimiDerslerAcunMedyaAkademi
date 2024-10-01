namespace Soru3;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı giriniz: ");
        double sayi1 = double.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = double.Parse(Console.ReadLine());

        Console.Write("İşlemi giriniz (+, -, *, /): ");
        char islem = char.Parse(Console.ReadLine());

        switch (islem)
        {
            case '+':
                Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
                break;
            case '-':
                Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
                break;
            case '*':
                Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
                break;
            case '/':
                if (sayi2 != 0)
                {
                    Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
                }
                else
                {
                    Console.WriteLine("Bölen 0 olamaz.");
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                break;
        }
    }
}
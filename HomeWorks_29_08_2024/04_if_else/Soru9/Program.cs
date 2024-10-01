namespace Soru9;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı giriniz: ");
        double sayi1 = double.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = double.Parse(Console.ReadLine());

        Console.Write("İşlem seçiniz (+, -, *, /): ");
        char islem = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double sonuc = 0;

        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    Console.WriteLine("Bölen sıfır olamaz.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                return;
        }

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}
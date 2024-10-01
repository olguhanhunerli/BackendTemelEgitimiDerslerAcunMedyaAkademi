namespace Soru10;

class Program
{
    static void Main()
    {
        Console.Write("Bir karakter giriniz (+, -, *, /, %): ");
        char islem = char.Parse(Console.ReadLine());

        switch (islem)
        {
            case '+':
                Console.WriteLine("Toplama");
                break;
            case '-':
                Console.WriteLine("Çıkarma");
                break;
            case '*':
                Console.WriteLine("Çarpma");
                break;
            case '/':
                Console.WriteLine("Bölme");
                break;
            case '%':
                Console.WriteLine("Mod Alma");
                break;
            default:
                Console.WriteLine("Geçersiz bir işlem.");
                break;
        }
    }
}
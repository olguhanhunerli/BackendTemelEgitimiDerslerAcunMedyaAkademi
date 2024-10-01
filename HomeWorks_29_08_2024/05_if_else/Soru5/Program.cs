namespace Soru5;

class Program
{
    static void Main()
    {
        Console.Write("Boyunuzu metre cinsinden giriniz (örn: 1.75): ");
        double boy = double.Parse(Console.ReadLine());

        Console.Write("Kilonuzu kilogram cinsinden giriniz: ");
        double kilo = double.Parse(Console.ReadLine());

        double vki = kilo / (boy * boy);

        Console.WriteLine($"Vücut Kitle İndeksiniz: {vki}");
    }
}
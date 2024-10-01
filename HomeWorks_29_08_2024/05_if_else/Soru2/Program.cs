namespace Soru2;

class Program
{
    static void Main()
    {
        Console.Write("Birinci kenarı giriniz: ");
        double kenar1 = double.Parse(Console.ReadLine());

        Console.Write("İkinci kenarı giriniz: ");
        double kenar2 = double.Parse(Console.ReadLine());

        Console.Write("Üçüncü kenarı giriniz: ");
        double kenar3 = double.Parse(Console.ReadLine());

        double s = (kenar1 + kenar2 + kenar3) / 2;
        double alan = Math.Sqrt(s * (s - kenar1) * (s - kenar2) * (s - kenar3));

        Console.WriteLine($"Üçgenin alanı: {alan} birim kare");
    }
}

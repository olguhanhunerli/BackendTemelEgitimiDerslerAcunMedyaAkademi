namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir saat girin (hh:mm tt formatında):");
        string saat12 = Console.ReadLine();
        DateTime saat24 = DateTime.ParseExact(saat12, "hh:mm tt", null);
        Console.WriteLine($"24 saat formatında: {saat24.ToString("HH:mm")}");

        // Veya tam tersi, 24 saat formatından 12 saat formatına çevirme
        Console.WriteLine("Bir saat girin (HH:mm formatında):");
        string saat24Format = Console.ReadLine();
        DateTime saat12Format = DateTime.ParseExact(saat24Format, "HH:mm", null);
        Console.WriteLine($"12 saat formatında: {saat12Format.ToString("hh:mm tt")}");
    }
}

namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih girin (gg/aa/yyyy):");
        DateTime tarih = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Girdiğiniz tarih haftanın {tarih.DayOfWeek} gününe denk geliyor.");
    }
}

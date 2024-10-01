namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci tarihi girin (gg/aa/yyyy):");
        DateTime tarih1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("İkinci tarihi girin (gg/aa/yyyy):");
        DateTime tarih2 = DateTime.Parse(Console.ReadLine());
        TimeSpan fark = tarih2 - tarih1;
        Console.WriteLine($"İki tarih arasındaki gün farkı: {fark.Days} gün");
    }
}

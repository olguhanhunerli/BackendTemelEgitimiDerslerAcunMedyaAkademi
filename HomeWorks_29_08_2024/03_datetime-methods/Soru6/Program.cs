namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir yıl girin:");
        int yil = int.Parse(Console.ReadLine());
        bool artikYilMi = DateTime.IsLeapYear(yil);
        Console.WriteLine(artikYilMi ? $"{yil} artık yıldır." : $"{yil} artık yıl değildir.");
    }
}

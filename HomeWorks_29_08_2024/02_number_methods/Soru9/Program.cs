namespace Soru9;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        double sayi = double.Parse(Console.ReadLine());

        double logaritma = Math.Log(sayi);

        Console.WriteLine($"Girilen sayının doğal logaritması: {logaritma}");
    }
}
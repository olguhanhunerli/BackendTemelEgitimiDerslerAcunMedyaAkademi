namespace Soru10;

class Program
{
    static void Main()
    {
        Console.Write("Bir ondalıklı sayı giriniz: ");
        double sayi = double.Parse(Console.ReadLine());

        Console.Write("Ondalık basamak sayısını giriniz: ");
        int basamak = int.Parse(Console.ReadLine());

        double yuvarlanmisSayi = Math.Round(sayi, basamak);

        Console.WriteLine($"Girilen sayının yuvarlanmış hali: {yuvarlanmisSayi}");
    }
}
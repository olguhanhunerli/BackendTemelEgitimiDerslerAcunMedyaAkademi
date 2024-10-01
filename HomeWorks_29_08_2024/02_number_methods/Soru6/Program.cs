namespace Soru6;


class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz (derece cinsinden): ");
        double derece = double.Parse(Console.ReadLine());
        
        double radyan = derece * (Math.PI / 180);
        double sinus = Math.Sin(radyan);

        Console.WriteLine($"Girilen sayının sinüs değeri: {sinus}");
    }
}
namespace Soru7;
class Program
{
    static void Main()
    {
        Console.Write("Bir açı giriniz (derece cinsinden): ");
        double derece = double.Parse(Console.ReadLine());

        double radyan = derece * (Math.PI / 180);
        
        Console.WriteLine($"Girilen açının radyan cinsinden değeri: {radyan}");
    }
}
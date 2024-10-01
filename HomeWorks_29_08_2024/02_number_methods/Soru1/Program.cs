namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir sayı giriniz :");
        double girilenSayi = double.Parse(Console.ReadLine());
        int sonuc = (int)Math.Round(girilenSayi);
        System.Console.WriteLine($"Girilen sayının en yakın tam sayısı : {sonuc}");
    }
}

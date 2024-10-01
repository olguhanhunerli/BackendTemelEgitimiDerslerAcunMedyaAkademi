namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
            System.Console.WriteLine("Bir sayı giriniz :");
            double girilenSayi = double.Parse(Console.ReadLine());
            double sonuc = Math.Sqrt(girilenSayi);
            System.Console.WriteLine($"Girilen sayının karekökü : {sonuc}");
    }
}

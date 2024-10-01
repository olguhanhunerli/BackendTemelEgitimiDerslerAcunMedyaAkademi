namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Bir sayı giriniz :");
       double girilenSayi = double.Parse(Console.ReadLine());
       int sonuc = (int)Math.Abs(girilenSayi);
       System.Console.WriteLine($"Girilen sayının mutlak değeri : {sonuc}");
    }
}

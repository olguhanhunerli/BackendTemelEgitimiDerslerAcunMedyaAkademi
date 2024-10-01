namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Birinci sayı giriniz :");
        double girilenSayi1 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("İkinci sayı giriniz :");
        double girilenSayi2 = double.Parse(Console.ReadLine());
        int sonuc = (int)Math.Max(girilenSayi1,girilenSayi2);
        System.Console.WriteLine($"Girilen sayının en büyüğü : {sonuc}");
    }
}

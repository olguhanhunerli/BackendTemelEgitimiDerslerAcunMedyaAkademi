namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Birinci sayı giriniz :");
        double girilenSayi1 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("İkinci sayı giriniz :");
        double girilenSayi2 = double.Parse(Console.ReadLine());
        int sonuc = (int)Math.Pow(girilenSayi1,girilenSayi2);
        System.Console.WriteLine($"Girilen: {girilenSayi1} Alınan Üs: {girilenSayi2} : {sonuc}");
    }
}

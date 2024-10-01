namespace Soru1;

class Program
{
    static void Main()
    {
        Console.Write("Para değerini giriniz (TL): ");
        double tutar = double.Parse(Console.ReadLine());
        double kdvOrani = (tutar > 1000) ? 0.08 : 0.20;
        double kdvTutarı = tutar * kdvOrani;
        double kdvliFiyat = tutar + kdvTutarı;

        Console.WriteLine($"KDV Tutarı: {kdvTutarı} TL");
        Console.WriteLine($"KDV'li Fiyat: {kdvliFiyat} TL");
    }
}
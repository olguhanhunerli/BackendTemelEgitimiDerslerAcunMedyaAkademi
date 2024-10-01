namespace Soru4;

class Program
{
    static void Main()
    {
        Console.Write("Yarı çapı giriniz: ");
        double yaricap = double.Parse(Console.ReadLine());
        double pi = Math.PI;

        double alan = pi * yaricap * yaricap;
        double cevre = 2 * pi * yaricap;

        Console.WriteLine($"Dairenin alanı: {alan} birim kare");
        Console.WriteLine($"Dairenin çevresi: {cevre} birim");
    }
}

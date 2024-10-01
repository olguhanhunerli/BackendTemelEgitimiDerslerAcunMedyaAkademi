namespace Soru3;

class Program
{
    static void Main()
    {
        const double acilisUcreti = 30;
        const double kmBasinaUcret = 20;
        const double minTutar = 100;

        Console.Write("Gidilen mesafeyi giriniz (KM): ");
        double km = double.Parse(Console.ReadLine());

        double tutar = acilisUcreti + (km * kmBasinaUcret);

        if (tutar < minTutar)
        {
            tutar = minTutar;
        }

        Console.WriteLine($"Taksimetre tutarı: {tutar} TL");
    }
}
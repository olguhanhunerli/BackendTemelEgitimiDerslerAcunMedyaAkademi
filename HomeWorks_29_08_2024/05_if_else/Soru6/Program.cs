namespace Soru6;

class Program
{
    static void Main()
    {
        const double armutFiyat = 45.50;
        const double bamyaFiyat = 81.40;
        const double domatesFiyat = 45.00;
        const double muzFiyat = 65.00;
        const double patlicanFiyat = 45.00;

        Console.Write("Armut kaç kilogram? ");
        double armutKg = double.Parse(Console.ReadLine());

        Console.Write("Bamya kaç kilogram? ");
        double bamyaKg = double.Parse(Console.ReadLine());

        Console.Write("Domates kaç kilogram? ");
        double domatesKg = double.Parse(Console.ReadLine());

        Console.Write("Muz kaç kilogram? ");
        double muzKg = double.Parse(Console.ReadLine());

        Console.Write("Patlıcan kaç kilogram? ");
        double patlicanKg = double.Parse(Console.ReadLine());

        double toplamTutar = (armutKg * armutFiyat) + (bamyaKg * bamyaFiyat) + 
                             (domatesKg * domatesFiyat) + (muzKg * muzFiyat) + 
                             (patlicanKg * patlicanFiyat);

        Console.WriteLine($"Toplam Tutar: {toplamTutar} TL");
    }
}
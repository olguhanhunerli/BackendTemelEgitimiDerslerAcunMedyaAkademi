namespace Soru8;

class Program
{
    static void Main()
    {
        Console.Write("Doğum yılınızı giriniz: ");
        int dogumYili = int.Parse(Console.ReadLine());

        int kalan = dogumYili % 12;
        string zodyak = kalan switch
        {
            0 => "Maymun",
            1 => "Horoz",
            2 => "Köpek",
            3 => "Domuz",
            4 => "Fare",
            5 => "Öküz",
            6 => "Kaplan",
            7 => "Tavşan",
            8 => "Ejderha",
            9 => "Yılan",
            10 => "At",
            11 => "Koyun",
            _ => "Geçersiz",
        };

        Console.WriteLine($"Çin Zodyağı Burcunuz: {zodyak}");
    }
}
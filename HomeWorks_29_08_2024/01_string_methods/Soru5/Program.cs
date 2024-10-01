namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir metin girin:");
        string metin = Console.ReadLine();

        Console.WriteLine("Aranacak metni girin:");
        string aranacakMetin = Console.ReadLine();

        int indeks = metin.IndexOf(aranacakMetin, StringComparison.OrdinalIgnoreCase);

         Console.WriteLine(indeks >= 0
            ? $"'{aranacakMetin}' metni, verilen metinde {indeks} indeksinde bulunuyor."
            : $"'{aranacakMetin}' metni, verilen metinde bulunamadı.");
    }
}

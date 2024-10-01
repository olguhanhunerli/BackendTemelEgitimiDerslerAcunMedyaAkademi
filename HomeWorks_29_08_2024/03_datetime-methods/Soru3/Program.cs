namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Bir tarih girin (gg/aa/yyyy):");
        DateTime tarih = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Eklemek istediğiniz gün sayısını girin:");
        int gunSayisi = int.Parse(Console.ReadLine());
        DateTime yeniTarih = tarih.AddDays(gunSayisi);
        Console.WriteLine($"Yeni tarih: {yeniTarih}");
    }
}

namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih girin (dd/MM/yyyy formatında):");
        string girilenTarih = Console.ReadLine();
        DateTime tarih = DateTime.ParseExact(girilenTarih, "dd/MM/yyyy", null);
        Console.WriteLine($"Girilen tarih: {tarih}");
    }
}

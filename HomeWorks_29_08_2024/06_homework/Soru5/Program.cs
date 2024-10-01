namespace Soru5;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        string sayi = Console.ReadLine();

        char[] sayiArray = sayi.ToCharArray();
        Array.Reverse(sayiArray);

        string tersSayi = new string(sayiArray);
        Console.WriteLine($"Ters sayı: {tersSayi}");
    }
}
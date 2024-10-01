namespace Soru3;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        string sayi = Console.ReadLine();

        var siraliRakamlar = sayi.OrderBy(c => c).ToArray();
        Console.WriteLine("Sonuç: " + string.Join(",", siraliRakamlar));
    }
}
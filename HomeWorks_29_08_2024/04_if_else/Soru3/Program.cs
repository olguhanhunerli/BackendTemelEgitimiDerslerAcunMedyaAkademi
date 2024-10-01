namespace Soru3;

class Program
{
    static void Main()
    {
        Console.Write("Bir karakter giriniz: ");
        char karakter = char.Parse(Console.ReadLine().ToLower());

        if (karakter == 'a' || karakter == 'e' || karakter == 'ı' || karakter == 'i' || 
            karakter == 'o' || karakter == 'ö' || karakter == 'u' || karakter == 'ü')
        {
            Console.WriteLine("Girdiğiniz karakter bir sesli harftir.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz karakter bir sesli harf değildir.");
        }
    }
}
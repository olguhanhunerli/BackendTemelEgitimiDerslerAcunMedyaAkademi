namespace Soru8;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        if (sayi % 3 == 0 && sayi % 5 == 0)
        {
            Console.WriteLine("Sayı hem 3'e hem de 5'e tam bölünmektedir.");
        }
        else if (sayi % 3 == 0)
        {
            Console.WriteLine("Sayı 3'e tam bölünmektedir.");
        }
        else if (sayi % 5 == 0)
        {
            Console.WriteLine("Sayı 5'e tam bölünmektedir.");
        }
        else
        {
            Console.WriteLine("Sayı ne 3'e ne de 5'e tam bölünmektedir.");
        }
    }
}
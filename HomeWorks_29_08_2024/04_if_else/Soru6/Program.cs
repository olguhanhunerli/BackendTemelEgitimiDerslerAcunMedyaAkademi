namespace Soru6;

class Program
{
    static void Main()
    {
        Console.Write("Notunuzu giriniz (0-100): ");
        int not = int.Parse(Console.ReadLine());
        string harfNotu = "";

        if (not >= 85)
        {
            harfNotu = "AA";
        }
        else if (not >= 70)
        {
            harfNotu = "BA";
        }
        else if (not >= 60)
        {
            harfNotu = "BB";
        }
        else if (not >= 50)
        {
            harfNotu = "CB";
        }
        else if (not >= 45)
        {
            harfNotu = "CC";
        }
        else if (not >= 30)
        {
            harfNotu = "DC";
        }
        else if (not >= 20)
        {
            harfNotu = "DD";
        }
        else
        {
            harfNotu = "FF";
        }

        Console.WriteLine($"Harf Notunuz: {harfNotu}");
    }
}
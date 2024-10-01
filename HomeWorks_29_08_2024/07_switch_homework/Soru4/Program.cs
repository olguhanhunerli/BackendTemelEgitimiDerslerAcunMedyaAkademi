namespace Soru4;

class Program
{
    static void Main()
    {
        Console.Write("Bir harf giriniz: ");
        char harf = char.Parse(Console.ReadLine().ToLower());

        switch (harf)
        {
            case 'a':
            case 'e':
            case 'ı':
            case 'i':
            case 'o':
            case 'ö':
            case 'u':
            case 'ü':
                Console.WriteLine("Sesli harf");
                break;
            default:
                Console.WriteLine("Sessiz harf");
                break;
        }
    }
}
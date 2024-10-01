namespace Soru6;

class Program
{
    static void Main()
    {
        Console.Write("Bir not giriniz (A, B, C, D, F): ");
        char not = char.Parse(Console.ReadLine().ToUpper());

        switch (not)
        {
            case 'A':
            case 'B':
            case 'C':
                Console.WriteLine("Geçti");
                break;
            case 'D':
            case 'F':
                Console.WriteLine("Kaldı");
                break;
            default:
                Console.WriteLine("Geçersiz bir not girdiniz.");
                break;
        }
    }
}
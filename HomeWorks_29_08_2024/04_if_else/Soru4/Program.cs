namespace Soru4;

class Program
{
    static void Main()
    {
        Console.Write("Bir yıl giriniz: ");
        int yil = int.Parse(Console.ReadLine());

        if ((yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0))
        {
            Console.WriteLine($"{yil} yılı artık yıldır.");
        }
        else
        {
            Console.WriteLine($"{yil} yılı artık yıl değildir.");
        }
    }
}
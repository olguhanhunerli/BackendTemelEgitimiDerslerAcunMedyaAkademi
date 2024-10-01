namespace Soru9;

class Program
{
    static void Main()
    {
        Console.Write("Bir yıl giriniz: ");
        int yil = int.Parse(Console.ReadLine());

        bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);

        if (artikYil)
        {
            Console.WriteLine($"{yil} yılı artık yıldır.");
        }
        else
        {
            Console.WriteLine($"{yil} yılı artık yıl değildir.");
        }
    }
}
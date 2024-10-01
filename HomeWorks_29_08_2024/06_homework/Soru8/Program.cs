namespace Soru8;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 0;

        Console.Write("Fibonacci serisi: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{a} ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}
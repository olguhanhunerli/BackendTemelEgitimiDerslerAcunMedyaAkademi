namespace HomeWork17;

class Program
{
    static void Main(string[] args)
    {
       //byte, short, int, ve long tiplerinde değişkenler oluşturun ve her birine aynı sayısal değeri (örneğin 42) atayın. Bu değişkenlerin bellekte kapladıkları alanı sizeof() operatörünü kullanarak ekrana yazdırın.sizeof() nasıl kullanılır, araştırın.

        Console.WriteLine("Size of byte: " + sizeof(byte) + " byte(s)");
        Console.WriteLine("Size of short: " + sizeof(short) + " byte(s)");
        Console.WriteLine("Size of int: " + sizeof(int) + " byte(s)");
        Console.WriteLine("Size of long: " + sizeof(long) + " byte(s)");
    }
}

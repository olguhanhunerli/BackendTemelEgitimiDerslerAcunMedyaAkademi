namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birini Sayıyı Giriniz");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Birini Sayıyı Giriniz");
        int sayi2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Birini Sayıyı Giriniz");
        int sayi3 = int.Parse(Console.ReadLine());

        if(sayi1>sayi2 && sayi2>sayi3)
        {
            System.Console.WriteLine($"En Büyük Sayi : {sayi1}");
        }
        else if (sayi1< sayi2 && sayi2> sayi3)
        {
            System.Console.WriteLine($"En Büyük Sayi : {sayi2}");
        }
        else
        {
            System.Console.WriteLine($"En Büyük Sayi : {sayi3}");
        }
    }
}

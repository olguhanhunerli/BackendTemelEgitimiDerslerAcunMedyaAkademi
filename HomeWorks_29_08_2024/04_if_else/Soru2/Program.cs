namespace Soru2;

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
       if (sayi1 >= sayi2 && sayi1 >= sayi3)
        {
            if (sayi2 >= sayi3)
            {
                Console.WriteLine("Birinci Sayi, İkinci Sayi, Üçüncü Sayi");
            }
            else
            {
                Console.WriteLine("Birinci Sayi, Üçüncü Sayi, İkinci Sayi");
            }
        }
        else if (sayi2 >= sayi1 && sayi2 >= sayi3)
        {
            if (sayi1 >= sayi3)
            {
                Console.WriteLine("İkinci Sayi,Birinci Sayi, Üçüncü Sayi");
            }
            else
            {
                Console.WriteLine("İkinci Sayi, Üçüncü Sayi, Birinci Sayi");
            }
        }
        else if (sayi3 >= sayi1 && sayi3 >= sayi2)
        {
            if (sayi1 >= sayi2)
            {
                Console.WriteLine("Üçüncü Sayi, Birinci Sayi, İkinci Sayi");
            }
            else
            {
                Console.WriteLine("Üçüncü Sayi, İkinci Sayi, Birinci Sayi");
            }
        }
    }
}

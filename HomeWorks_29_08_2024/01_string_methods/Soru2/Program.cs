namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Bir metin giriniz");
       string metin = Console.ReadLine();
       System.Console.WriteLine("Bütün harfler küçük :" +metin.ToLower());
       System.Console.WriteLine("Bütün Harfler büyük :" +metin.ToUpper());
    }
}

namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir Sayı Giriniz");
        int sayi1 = int.Parse(Console.ReadLine());
        if (sayi1 > 0)
        {
            System.Console.WriteLine("Sayiniz Pozitiftir");
        }
            
        else if (sayi1<0)   
        {
            System.Console.WriteLine("Sayiniz Negatiftir");
        }
        else {System.Console.WriteLine("Sayınız Sıfırdır.");}
            
        
    }
}

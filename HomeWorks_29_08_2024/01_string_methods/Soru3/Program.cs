namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Bir Cümle Giriniz :");
       string cumle = Console.ReadLine();

       System.Console.WriteLine("Aranacak Kelimeyi Giriniz :");
       string arananKelime = Console.ReadLine();
       int sayac  =    cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         .Count(kelime => kelime.Equals(arananKelime, StringComparison.OrdinalIgnoreCase));

       Console.WriteLine($"Girilen cümlede '{arananKelime}' kelimesi {sayac} kez geçiyor.");
    }
}

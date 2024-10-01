namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir cümle giriniz.");
        string cumle = Console.ReadLine();
        string [] kelimeler = cumle.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;
        System.Console.WriteLine("Girilen cümledeki kelime sayisi: "+kelimeSayisi);
    }
}

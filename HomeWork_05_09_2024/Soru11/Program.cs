namespace Soru11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir cümle girin: ");
        string cumle = Console.ReadLine();
        string[] kelimeler = cumle.Split(' ');

        int i = kelimeler.Length - 1;
        while (i >= 0)
        {
            Console.WriteLine(kelimeler[i]);
            i--;
        }

    }
}

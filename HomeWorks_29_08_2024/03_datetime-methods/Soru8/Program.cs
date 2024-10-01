namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
      DateTime simdikiTarih = DateTime.Now;
        Console.WriteLine($"Şu anki ay: {simdikiTarih.ToString("MMMM")}");
    }
}

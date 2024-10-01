namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Birinci tarihi girin (gg/aa/yyyy):");
        DateTime tarih1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("İkinci tarihi girin (gg/aa/yyyy):");
        DateTime tarih2 = DateTime.Parse(Console.ReadLine());

        int sonuc = DateTime.Compare(tarih1, tarih2);
        if (sonuc < 0)
        {
            Console.WriteLine("Birinci tarih, ikinci tarihten önce.");
        }
        else if (sonuc > 0)
        {
            Console.WriteLine("Birinci tarih, ikinci tarihten sonra.");
        }
        else
        {
            Console.WriteLine("İki tarih aynı.");
        }
    }
}

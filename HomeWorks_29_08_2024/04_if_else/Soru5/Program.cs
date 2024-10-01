namespace Soru5;

class Program
{
    static void Main()
    {
        Console.Write("Birinci kenarı giriniz: ");
        int kenar1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci kenarı giriniz: ");
        int kenar2 = int.Parse(Console.ReadLine());

        Console.Write("Üçüncü kenarı giriniz: ");
        int kenar3 = int.Parse(Console.ReadLine());

        if (kenar1 + kenar2 > kenar3 && kenar1 + kenar3 > kenar2 && kenar2 + kenar3 > kenar1)
        {
            Console.WriteLine("Bu kenarlarla bir üçgen oluşturulabilir.");
        }
        else
        {
            Console.WriteLine("Bu kenarlarla bir üçgen oluşturulamaz.");
        }
    }
}
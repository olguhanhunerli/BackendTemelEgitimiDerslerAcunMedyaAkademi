namespace HomeWork02;

class Program
{
    static void Main(string[] args)
    {
        //double tipinde bir değişken oluşturun ve bu değişkene bir ondalıklı sayı atayın. Bu sayının karesini hesaplayıp yeni bir double değişkene atayın ve sonucu ekrana yazdırın.
            double sayi = 1.18;
            double sonuc ;
            sonuc = sayi*sayi;
            System.Console.WriteLine($"Double sayinin karesi {sonuc}");
    }
}

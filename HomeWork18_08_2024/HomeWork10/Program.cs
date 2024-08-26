namespace HomeWork10;

class Program
{
    static void Main(string[] args)
    {
        //int tipinde üç değişken oluşturun ve bunlara sırasıyla 5, 10 ve 15 değerlerini atayın. Bu değişkenlerin ortalamasını hesaplayıp double tipinde bir değişkene atayın ve sonucu ekrana yazdırın.
            int number1 = 5;
            int number2 = 10;
            int number3 = 15;
            double sonuc;
            sonuc = (double)(number1+number2+number3)/3;
            System.Console.WriteLine(sonuc);
    }
}

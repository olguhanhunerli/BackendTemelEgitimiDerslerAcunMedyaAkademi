namespace HomeWork08;

class Program
{
    static void Main(string[] args)
    {
         //double tipinde bir değişken oluşturun ve içine 3.14 değerini atayın. Bu değeri int tipine dönüştürüp yeni bir değişkene atayın ve sonucu ekrana yazdırın. Sonucu yorumlayın.
            double number1 = 3.14;
            int sonuc;
            sonuc = (int)(number1);
            System.Console.WriteLine(sonuc);
            //double türünü int türüne çevirirken int sadece tam sayıları aldığı için . ifadesinden sonrasını görmez ve o şekilde yazdırır.
    }
}

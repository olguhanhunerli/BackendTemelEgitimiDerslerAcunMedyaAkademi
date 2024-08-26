namespace HomeWork13;

class Program
{
    static void Main(string[] args)
    {
        //long tipinde bir değişken oluşturun ve içine çok büyük bir sayı atayın, örneğin 500000000000 gibi. Bu değeri int tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.
            long number1 = 500000000000;
            int number2 = (int)(number1);
            System.Console.WriteLine(number2);

            //long veri tipi daha fazla byte olarak yer kapladığı için int türüne göre direkt atamak mümkün olmayıp o değere en yakın değeri yazdırıyor.
    }
}

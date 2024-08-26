namespace HomeWork15;

class Program
{
    static void Main(string[] args)
    {
       //string tipinde bir değişken oluşturun ve içine "True" yazın. Bu string'i bool tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
            string isTrue = "true";
            bool isActive = Convert.ToBoolean(isTrue);
            System.Console.WriteLine(isActive);
    }
}

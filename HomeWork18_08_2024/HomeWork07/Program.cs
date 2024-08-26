namespace HomeWork07;

class Program
{
    static void Main(string[] args)
    {
       //int tipinde bir değişken oluşturun ve içine büyük bir sayı (örneğin 1000000) atayın. Bu değeri byte tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.
        
            int number1 = 11111;
            byte number2;
            number2 = Convert.ToByte(number1);
            System.Console.WriteLine(number2);

            //Dönüştürülemez. Çünkü byte sadece 8 bitlik değer alır fakat bizim girdiğimiz değer 8byte yani 255 sayısından büyüktür.
            /*Verdiği hata
            Unhandled exception. System.OverflowException: Value was either too large or too small for an unsigned byte.
                at System.Convert.ThrowByteOverflowException()
                at System.Convert.ToByte(Int32 value)
                at odevlero.Program.Main(String[] args) in C:\Users\Olguhan\Desktop\Homework\odevlero\Program.cs:line 55
            
            */
    }
}

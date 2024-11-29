using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // gọi hàm
        int ketQua = tinhTong(10, 11);

        Console.Write($"Tổng 2 số là: {ketQua}");

        Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");
        Console.WriteLine("Mời bạn nhập số: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number3;
        int reverseNumber = kiemTra(number3);

        
        int number = Convert.ToInt32(Console.ReadLine());
        for (int count = 2; count <= number; count++)
        {
            bool Checkprime=IsPrime(count);

            if(Checkprime==true){
                Console.Write($"{count} ");
            }
           
        }

        Console.WriteLine("Mời bạn nhập một số: ");
        

        if (reverseNumber == originalNumber)
        {
            Console.WriteLine($"Số {originalNumber} là số đối xứng");
        }
        else
        {
            Console.WriteLine($"Số {originalNumber} không là số đối xứng");
        }

    }
    //Kiem tra so doi xung
    private static int kiemTra(int number ){

        
        int originalNumber = number;
        int reverseNumber = 0;
        while (number > 0)
        {
            int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }
        return reverseNumber;
    }
    //Khai bao ham kiem tra so nhueyn to
    private static bool IsPrime(int number)
    {
        if (number <= 2)
        {
            return false;
        }
        for(int count=2;count<=Math.Sqrt(number);count++){
            if(number%count==0){
                return false;
            }
        }
        return true;
    }

    // khai báo hàm
    private static int tinhTong(int number1, int number2)
    {
        return number1 + number2;
    }
}

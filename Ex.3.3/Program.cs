// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Ex3.3 - Ứng dụng đọc số thành chữ
using System;
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số cần đọc: ");
            int n = int.Parse(Console.ReadLine());
            string[] num = new string[10] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] num2 = new string[]{"eleven", "twelve", "thirteen", "fourteen", "fifteen"};
            if (n>=0 &&n < 10)
            {
                Console.WriteLine(num[n]);
            }
            if (n>=11 && n<16)
            {
               Console.WriteLine(num2[n-11]);
            }
            if (n>=16 && n<20)
            {
                Console.WriteLine(num[n-10]+"teen");
            }
            if (n>=20 && n<100)
            {
                Console.WriteLine(num[n/10]+"ty "+num[n%10]);
            }
            if (n>=100 && n<1000)
            {
                Console.WriteLine(num[n/100]+" hundred "+num[(n%100)/10]+"ty "+num[n%10]);
            }
            else
            {
                Console.WriteLine("Out of ability");
            }
        }
    }
}
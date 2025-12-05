using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_question
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the first number :");
                  int num1 = int.Parse(Console.ReadLine());

               Console.Write("Enter the second number:");
                  int num2 = int.Parse(Console.ReadLine());

           // شروع از کوچکترین عدد بین num1 و num2
                  int startDivisor = (num1 < num2) ? num1 : num2;

                  int gcd = GCDRecursive(num1, num2, startDivisor);

                  Console.WriteLine("Greatest Common Divisor({0}, {1}) = {2}",num1,num2,gcd);
                  Console.ReadKey();
        }
           // متد بازگشتی برای پیدا کردن بزرگترین مقسوم علیه مشترک
        static int GCDRecursive(int a, int b, int divisor)
        {
             // شرط پایان: وقتی مقسوم‌علیه به صفر رسید
                  if (divisor == 0)
                     return 1;

             // اگر هر دو عدد بر این مقسوم‌علیه بخش‌پذیر باشند، این بزرگترین مشترک است
                  if (a % divisor == 0 && b % divisor == 0)
                     return divisor;

             // در غیر این صورت، ادامه بده با یک عدد کوچکتر
                 return GCDRecursive(a, b, divisor - 1);
        }
    }
}

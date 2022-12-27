using System; // System is name space
namespace CsharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit
            int num = 123456;
            long newNum = num;
            Console.WriteLine(newNum);

            // explicit
            double x = 12345.5;
            int a = (int)x;
            Console.WriteLine(a);
        }
    }
}

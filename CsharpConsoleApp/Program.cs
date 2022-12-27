using System; // System is name space
namespace CsharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            int intVar = 10;
            float floatVar = 10.2f;
            char charVar = 'E';
            bool boolVar = false;

            Console.WriteLine(message);
            Console.WriteLine(intVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(charVar);
            Console.WriteLine(boolVar);
            Console.ReadKey();
        }
    }
}

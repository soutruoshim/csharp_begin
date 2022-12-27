using System; // System is name space
namespace CsharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i< 11; i++)
            {
                Console.WriteLine($"{i} - Hello!");
            }


            int j = 1;
            while(j< 11)
            {
                Console.WriteLine($"{j} - Hello!");
                j++;
            }

            j = 0;
            do
            {
                Console.WriteLine($"{j} - Hello!");
                j++;
            } while (j < 11);

        }
    }
}

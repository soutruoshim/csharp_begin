using System; // System is name space
namespace CsharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Age = 15, FullName="Join Son"};
            Console.WriteLine(person.GetDetail());

            Professor processor = new Professor() { Age = 45, FullName = "Lixa", Subject = "Math" };
            Console.WriteLine(processor.GetDetail());

            Student student = new Student() { Age = 20, FullName = "Eyjo", Grade = 2 };
            Console.WriteLine(student.GetDetail());
        }
    }
}

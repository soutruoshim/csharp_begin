using System; // System is name space
using System.Collections;

namespace CsharpConsoleApp
{
    public delegate void StringDelegate(string text);
    class Program
    {
        static void Main(string[] args)
        {
            StringDelegate stringDelegate = ToUpperCase;
            WriteOutput("Hello World", stringDelegate);

            //Events
            Strings myString =
        }
        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void ToLowerCase(string text) => Console.WriteLine(text.ToLower());
        static void TextChange(string text) => Console.WriteLine($"You Enter Text: {text}");
        static void WriteOutput(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
            stringDelegate(text);
        }
    } 
    public class Strings
    {
        private String stringValue;
        public event StringDelegate stringEvent;

        public string Value {
            set {
                this.stringValue = value;
                this.stringEvent(this.stringValue);
            }
        }

    }
}

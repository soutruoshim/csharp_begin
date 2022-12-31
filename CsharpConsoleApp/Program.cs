using System; // System is name space
using System.Collections;

namespace CsharpConsoleApp
{
    public delegate void StringDelegate(string text);
    class Program
    {
        static void Main(string[] args)
        {
            // Event
            Strings strings = new Strings();
            strings.stringEvent += TextChange;
            string str = "";
            do
            {
                if (!str.Equals("exit")) strings.Value = str;

            } while (!str.Equals("exit"));


          
        }
        public static void TextChange(string text) => Console.WriteLine(text);

    
    } 
    public class Strings
    {
        private string stringValue;
        public event StringDelegate stringEvent;
        public string Value
        {
            set
            {
                this.stringValue = value;
                this.stringEvent(this.stringValue);
            }
        }
    }
    
}

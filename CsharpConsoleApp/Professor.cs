using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    public class Professor : IPerson, ITest
    {
        public string Subject { get; set; }
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetDetail()
        {
            throw new NotImplementedException();
        }

        public string GetDetail(double height)
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}

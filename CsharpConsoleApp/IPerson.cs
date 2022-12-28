using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    public interface IPerson
    {
        string FullName { get; set; }
        int Age { get; set; }

        string GetDetail();
        string GetDetail(double height);
    }

    public interface ITest
    {
        void Test();
    }
}

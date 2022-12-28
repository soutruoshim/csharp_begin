using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    public class Person : IPerson
    {
        public string FullName { get ; set; }
        public int Age { get; set; }

        public string GetDetail() => $"{FullName} of age {Age}";
      
        public string GetDetail(double height) => $"{FullName} of age {Age}";
      
    }
}

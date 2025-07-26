using DemoOOP03.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03.Interface_Ex01
{
    internal class MyType : IMyType
    {
        public double salary{ get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello World");
        }
    }

}

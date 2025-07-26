using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03.Interface
{
    internal interface IMyType
    {

        void MyFun();

        double salary { get; set; }

        void print()
        {
            Console.WriteLine("Default implemented method [fully implemented method]");

        }
    }

}

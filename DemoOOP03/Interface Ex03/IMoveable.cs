using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03.Interface_Ex03
{
    internal interface IMoveable
    {
        int Speed { get; set; }

        void Left(); 

        void Right();   

        void Forward();
        
        void Backward();
    }
}

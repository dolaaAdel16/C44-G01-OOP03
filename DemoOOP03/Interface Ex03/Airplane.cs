using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03.Interface_Ex03
{
    internal class Airplane : IMoveable, IFlyabe
    {
        int IMoveable.Speed { get ; set ; }
        int IFlyabe.Speed { get ; set ; }

        void IMoveable.Backward()
        {
            Console.WriteLine("Airplane IMoveable Backward");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("Airplane IMoveable Forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Airplane IMoveable Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Airplane IMoveable Right");
        }

        void IFlyabe.Backward()
        {
            Console.WriteLine("Airplane IFlyabe Backward");
        }

        void IFlyabe.Forward()
        {
            Console.WriteLine("Airplane IFlyabe Forward");
        }

        void IFlyabe.Left()
        {
            Console.WriteLine("Airplane IFlyabe Left");
        }

        void IFlyabe.Right()
        {
            Console.WriteLine("Airplane IFlyabe Right");
        }
    }
}

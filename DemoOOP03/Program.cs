using DemoOOP03.Interface;
using DemoOOP03.Interface_Ex01;
using DemoOOP03.Interface_Ex02;
using DemoOOP03.Interface_Ex03;

namespace DemoOOP03
{
    internal class Program
    {

        //static void PrintTenNumbers(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{ series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void PrintTenNumbers(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void PrintTenNumbers(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void PrintTenNumbers(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        static void Main()
        {
            #region V01
            //Console.WriteLine("V01");  

            //MyType myType = new MyType();
            //myType.salary = 12000; 
            //Console.WriteLine(myType.salary);
            //myType.MyFun();

            //myType.print(); 

            //IMyType mytype1 = new IMyType();
            //myType1.myfun();

            //IMyType myType;

            //myType = new MyType();

            //myType.salary = 12000;
            //Console.WriteLine(myType.salary);
            //myType.MyFun();
            //myType.print(); 
            #endregion

            #region V02
            //Console.WriteLine("V02")
            //SeriesByTwo seriesbytwo = new SeriesByTwo();
            //SeriesByThree seriesbythree = new SeriesByThree();
            //SeriesByFour seriesbyfour = new SeriesByFour(); 

            //PrintTenNumbers(seriesbytwo);

            //int[] Numbers = { 4, 8, 6, 1, 0, 7, 2, 5 }; 

            //Array.Sort(Numbers);

            //foreach (int item in Numbers)
            //{ 
            //    Console.Write($"{item}" + " ");    
            //}


            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){ Id = 1, Name = "Ahemd", Age = 22, Salary = 12000 } ,
            //    new Employee(){ Id = 2, Name = "Omar", Age = 24, Salary = 15000 } ,
            //    new Employee(){ Id = 1, Name = "Mostafa", Age = 27, Salary = 20000 }
            //};

            //Array.Sort(employees);

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);   
            //} 
            #endregion

            #region V03
            //Console.WriteLine("V03");

            //Car car = new Car(); 

            //car.Speed = 100;
            //car.Forward(); 

            //Airplane airplane = new Airplane();

            //IMoveable moveable = airplane;
            //moveable.Forward(); 

            //IFlyabe flyabe = airplane;
            //flyabe.Forward();    
            #endregion



        }
    }
}

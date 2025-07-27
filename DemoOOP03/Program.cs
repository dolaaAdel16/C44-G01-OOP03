using DemoOOP03.Interface;
using DemoOOP03.Interface_Ex01;
using DemoOOP03.Interface_Ex02;
using DemoOOP03.Interface_Ex03;
using System.Collections;
using System.Text;

namespace DemoOOP03
{
    internal class Program
    {
        //static void Main()

        #region Func
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
        //static void Main()
        //{
            #region Q01
            //Q01 
            //Question 1:
            // What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class 
            #endregion

            #region Q02
            //Q02 
            //Question 2:
            // Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private  

            #endregion

            #region Q3
            //Question 3:
            //Can an interface contain fields in C#?
            //b) No

            #endregion

            #region Q04
            //Question 4:
            //In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Q05
            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //None of them ( : is used to implement the interface ) 
            #endregion

            #region Q06
            //Question 6:
            //Can an interface contain static methods in C#?
            //a) Yes 
            #endregion

            #region Q07
            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public

            #endregion

            #region Q08
            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access

            #endregion

            #region Q09
            //Question 9:
            // In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors 
            #endregion

            #region Q10
            //Question 10:
            // How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas 
            #endregion

            #region P02 Q01
            //P02 Q01
            //ICircle circle = new Circle { Radius = 5 };
            //IRectangle rectangle = new Rectangle { width = 4, Height = 6 };

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            #endregion

            #region P02 Q02
            //P02 Q02
            //IAuthenticationService authService = new BasicAuthenticationService();

            //bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
            //bool isAuthorized = authService.AuthorizeUser("admin", "admin");

            //Console.WriteLine($"Authenticated: {isAuthenticated}");
            //Console.WriteLine($"Authorized: {isAuthorized}"); 
            #endregion

            #region P02 Q03
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("AhmedAdel@gmail.com", "Welcome!");
            //smsService.SendNotification("1234567890", "Your code is 1234");
            //pushService.SendNotification("user01", "You have a new message"); 
            #endregion








        //} 
        #endregion

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

            #region V04
            //Console.WriteLine("V04");


            //int[] Arr01 = { 1 , 2 , 3 };
            //int[] Arr02 = { 4 , 5 , 6 };

            //string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            //string[] Arr02 = { "Amir", "Amr", "Ziad" };

            // StringBuilder[] Arr01 = new StringBuilder[]
            // {
            //     new StringBuilder("Ahmed"),
            //     new StringBuilder("Ali"),
            //     new StringBuilder("Omar")
            // };

            // StringBuilder[] Arr02 = new StringBuilder[]
            //{
            //     new StringBuilder("Amr"),
            //     new StringBuilder("Adel"),
            //     new StringBuilder("Ziad")
            //};

            // Console.WriteLine();

            // Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            // Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            // Arr02 = (StringBuilder[])Arr01.Clone(); 
            // Arr02[0].Append( "Ahmed Adel");

            // Console.WriteLine();

            // Console.WriteLine(Arr01[0]);    

            //Arr02 = (int[])Arr01.Clone(); 

            //Console.WriteLine();    

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");


            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); 
            #endregion

            #region V06
            //Console.WriteLine("V05");

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 3, Name = "AMR", Age = 26, Salary = 14000 };

            ////E02 = E01;
            //E02 = (Employee)E01.Clone();
            //E02 = new Employee(E01);

            //E01.Salary = 5; 

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
            //Console.WriteLine(E01);
            //Console.WriteLine(E02); 
            #endregion


            #region V07
            //Console.WriteLine("V07");

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id = 1 , Name = "Ahmed" , Age = 30 , Salary = 12000},
            //    new Employee(){Id = 2 , Name = "Amr" , Age = 22 , Salary = 15000},
            //    new Employee(){Id = 3 , Name = "Mostafa" , Age = 23 , Salary = 16000}

            //};

            //Array.Sort(employees);

            ////int X  = employees[1].CompareTo(employees[0]);

            //foreach (Employee item in employees)
            //{

            //    Console.WriteLine(item);
            //}
            ////Console.WriteLine(X);

            #endregion




        }
    }


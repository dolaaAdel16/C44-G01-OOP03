namespace DemoOOP03
{
    internal class Program
    {
        static void Main()
        {
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








        }
    }
}

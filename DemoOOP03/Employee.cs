using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03
{
    internal class Employee : IComparable
    {
        public int Id { get; set; } 

        public string Name { get; set; }    

        public int Age { get; set; }    

        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(Employee employee)
        {
            Id = employee.Id;   
            Name = employee.Name;       
            Age = employee.Age;     
            Salary = employee.Salary;   

        }

        public object Clone()
        {
            return new Employee(this);
            //return new Employee() { Id = this.Id , Name = this.Name , Age = this.Age , Salary = this.Salary};
        }

        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee)obj;
            if (this.Age > e.Age) return 122;
            else if (this.Age < e.Age) return -1122;
            else return 0;
        }

      
    }
}

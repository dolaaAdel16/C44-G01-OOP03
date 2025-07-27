﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03
{
    internal class Employee 
    {
        public int Id { get; set; } 

        public string Name { get; set; }    

        public int Age { get; set; }    

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}";
        }
    }
}

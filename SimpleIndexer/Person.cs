using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using System.Threading.Tasks;

namespace  SimpleIndexer

{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public int Age { get; set; }

        //custom constructor
        public Person(string firstName,string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Person(){}

        //methods
        public override string ToString()=>$"Name:{FirstName} {LastName}, Age: {Age}";//expresion-bodied member
        
        
    }
}

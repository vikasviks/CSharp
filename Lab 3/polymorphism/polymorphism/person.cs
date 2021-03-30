using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    public class person
    {
        string name;
        int age;

        public person( string name,int age)
        {
            this.name = name;
            this.age = age;

        }

        public override string  ToString()
        {
            return (name + " is " + age + " years old.");
        }



    }
    

}

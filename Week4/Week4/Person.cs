using System;
using System.Collections.Generic;
using System.Text;

namespace Week4
{
    class Person
    {
        string name;
        public Person (string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public override string ToString()
        {
            string name = ("The name is :" + this.name);
            return name;
        }
    }
}

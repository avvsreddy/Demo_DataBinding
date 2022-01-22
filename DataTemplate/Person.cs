using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTemplate
{
    class Person
    {
        public Person(string Name,int Age,string Image)
        {
            name = Name;
            age = Age;
            image = Image;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}

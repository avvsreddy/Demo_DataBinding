using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace _11_BindingToCollections
{
    public class PeopleCollection : ObservableCollection<Person>
    {
        
        public PeopleCollection()
        {
            
            Add(new Person { FirstName = "Venkat", LastName = "Shiva Reddy" });
            Add(new Person { FirstName = "Rohith", LastName = "Reddy" });
            Add(new Person { FirstName = "Sachin", LastName = "Tendulkar" });
            Add(new Person { FirstName = "Rahul", LastName = "Dravid " });

        }
       
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //public override string ToString()
        //{
        //    return this.FirstName;
        //}
    }
}

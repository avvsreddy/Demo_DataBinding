using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace _13_BindingValidation
{
    public class Person
    {
        public Person()
        {
            Code = 101;
            PersonName = "Venkat";
            Age = 35;
        }
      
        public int Code { get; set; }
        public string PersonName { get; set; }
    
        public int Age { get; set; }
    }

    public class AgeRangeRule : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int age = 0;
            try
            {
                if (((String)value).Length > 0)
                {
                    age = int.Parse(value.ToString());
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Illegal charectors or " + e.Message);
            }

            if (age > Max || age < Min)
            {
                string str = String.Format("Enter age in between {0} and {1}", Min, Max);
                return new ValidationResult(false, str);
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }

}

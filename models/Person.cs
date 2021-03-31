using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public Person()
        {
                
        }

        public override string ToString()
        {
            return $"Age: {Age}, Name: {Name}, LastName: {LastName}";
        }

        public string Concatenar<G>(G left, G right)
        {
            //string result = string.Empty;
            StringBuilder result = new StringBuilder();
            result.Append(left);
            result.Append(right);
            
            return result.ToString();
        }
    }
}

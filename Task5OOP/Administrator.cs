using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OOP
{
    class Administrator : Person
    {
        public Administrator(string FirstName, string LastName) : base(FirstName, LastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

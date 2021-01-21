using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OOP
{
    class Pilot : Person
    {
        string rank;
        public Pilot(string FirstName, string LastName, string Rank) : base(FirstName, LastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.rank = Rank;
        }

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

    }
}

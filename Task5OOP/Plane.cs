using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OOP
{
    class Plane
    {
        public string start;
        public string middle;
        public string end;
        public double distance;
        public bool weather;


        public Plane(string Start, string Middle, string End, double Distance, bool Weather)
        {
            this.start = Start;
            this.middle = Middle;
            this.end = End;
            this.distance = Distance;
            this.weather = Weather;
        }

        public string Start
        {
            get { return start; }
            set { start = value; }
        }

        public string Middle
        {
            get { return middle; }
            set { middle = value; }
        }

        public string End
        {
            get { return end; }
            set { end = value; }
        }

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public bool Weather
        {
            get { return weather; }
            set { weather = value; }
        }
    }
}

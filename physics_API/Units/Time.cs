using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physics_API.Units
{
    public class Time
    {
        public enum timeUnit { Second=1, Minut=2, Hour=3 }
        private double magnitude;
        private timeUnit units;

        public double Magnitude
        {
            get
            {
                return magnitude;
            }

            set
            {
                magnitude = value;
            }
        }

        public timeUnit Units
        {
            get
            {
                return units;
            }
        }

        public Time(double mag, timeUnit unit)
        {
            Magnitude = mag;
            units = unit;
        }

        public void convertTo(timeUnit to)
        {
            while(units > to)
            {
                --units;
                Console.WriteLine("here");
                magnitude *= 60;
            }
            while (units < to)
            {
                ++units;
                Console.WriteLine("there");
                magnitude /= 60;
            }
        }

        public static Time operator +(Time t1, Time t2)
        {
            if (t1.Units != t2.Units)
            {
                t2.convertTo(t1.units);
            }
            return new Time(t1.magnitude + t2.magnitude, t1.Units);
        }
        public static Time operator -(Time t1, Time t2)
        {
            if (t1.Units != t2.Units)
            {
                t2.convertTo(t1.units);
            }
            return new Time(t1.magnitude - t2.magnitude, t1.Units);
        }
    }
}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physics_API.Units
{
    public class Time
    {
        public enum timeUnit { Second, Minut, Hour }
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

            set
            {
                units = value;
            }
        }

        public Time(double mag, timeUnit unit)
        {
            Magnitude = mag;
            Units = unit;
        }

        public void convertTo(timeUnit to)
        {

        }
    }
}
    

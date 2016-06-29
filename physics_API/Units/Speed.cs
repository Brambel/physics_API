using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physics_API.Units
{
    
    public class Speed
    {
        private Time.timeUnit bottomUnit;
        private Distance.distanceUnit topUnit;
        private double magnitude;
        public Speed(double mag, Distance.distanceUnit dist, Time.timeUnit time)
        {
            Magnitude = mag;
            topUnit = dist;
            bottomUnit = time;
        }
        public Time.timeUnit BottomUnit
        {
            get
            {
                return bottomUnit;
            }

            set
            {
                bottomUnit = value;
            }
        }

        public Distance.distanceUnit TopUnit
        {
            get
            {
                return topUnit;
            }

            set
            {
                topUnit = value;
            }
        }

        

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

        public string Units
        {
            get { return TopUnit.ToString() + " / " + BottomUnit.ToString(); }
        }

        public string toString()
        {
            return "Magnitude: " + Magnitude + "\n Units: " + Units;
        }
    }
}

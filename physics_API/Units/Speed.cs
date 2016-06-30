using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physics_API.Units
{
    
    public class Speed
    {
        private Time denominator;
        private Distance numerator;
        public Speed(Distance distance, Time time)
        {
            numerator = distance;
            denominator = time;
        }
        public Time Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                denominator = value;
            }
        }

        public Distance Numerator
        {
            get
            {
                return numerator;
            }

            set
            {
                numerator = value;
            }
        }

        

        public double Magnitude
        {
            get
            {
                return numerator.Magnitude/denominator.Magnitude;
            }


        }

        public string Units
        {
            get { return Numerator.Units.ToString() + " / " + Denominator.Units.ToString(); }
        }

        public string toString()
        {
            return "Magnitude: " + Magnitude + "\n Units: " + Units;
        }

        public static Speed operator +(Speed s1, Speed s2)
        {
            return new Speed(s1.numerator + s2.numerator, s1.denominator + s2.denominator);
        }

        public static Speed operator -(Speed s1, Speed s2)
        {
            return new Speed(s1.numerator - s2.numerator, s1.denominator - s2.denominator);
        }

    }
}

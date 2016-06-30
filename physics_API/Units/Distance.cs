using System;

namespace physics_API.Units
{
    public class Distance
    {
        public enum distanceUnit { Milimeter=-3, Meter=0, Kilometer=3}
        private double magnitude;
        private distanceUnit units;

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

        public distanceUnit Units
        {
            get
            {
                return units;
            }
        }

        public Distance(double mag, distanceUnit unit)
        {
            Magnitude = mag;
            this.units = unit;
        }

        public void convertTo(distanceUnit to)
        {
            double factor = Math.Pow(10, units - to);
            units = to;
            magnitude *= factor;

        }

        public static Distance operator +(Distance d1, Distance d2)
        {
            if (d1.Units != d2.Units)
            {
                d2.convertTo(d1.Units);
            }
            return new Distance(d1.Magnitude + d2.Magnitude, d1.Units);
        }
        public static Distance operator -(Distance d1, Distance d2)
        {
            if (d1.Units != d2.Units)
            {
                d2.convertTo(d1.Units);
            }
            return new Distance(d1.Magnitude - d2.Magnitude, d1.Units);
        }

    }
}
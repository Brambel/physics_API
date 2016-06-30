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

            set
            {
                units = value;
            }
        }

        public Distance(double mag, distanceUnit unit)
        {
            Magnitude = mag;
            this.Units = unit;
        }

        public void convertTo(distanceUnit to)
        {
            double factor = Math.Pow(10, units - to);
            units = to;
            magnitude *= factor;

        }

    }
}
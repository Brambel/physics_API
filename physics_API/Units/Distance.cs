
namespace physics_API.Units
{
    public class Distance
    {
        public enum distanceUnit { Milimeter, Meter, Kilometer}
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
    }
}

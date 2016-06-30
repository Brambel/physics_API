using System;
using physics_API.Units;

namespace physics_API
{
    public static  class Motion
    {
        public static Speed averageSpeed(Distance distanceFinal, Distance distance0, Time timeFinal, Time time0) 
        {
            return new Speed(distanceFinal-distance0, timeFinal-time0);
        }

        public static Distance findDistance(Point start, Point finish, Distance.distanceUnit unit)
        {
            double x = finish.X - start.X;
            double y = finish.Y - start.Y;
            double z = finish.Z - start.Z;
            double mag = Math.Sqrt((x * x) + (y * y)+(z*z));
            return new Distance(mag, unit);
        }
        public static Distance findDistanceTraveld(Point[] points, Distance.distanceUnit unit)
        {
            int length = points.Length;
            Distance final = new Distance(0, unit);
            for (int i = 1; i < length; ++i)
            {
                final = final + findDistance(points[i - 1] , points[i], unit);
            }
            return final;
        }
    }
}

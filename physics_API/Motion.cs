
using physics_API.Units;

namespace physics_API
{
    public static  class Motion
    {
        public static Speed averageSpeed(Distance distanceFinal, Distance distance0,
            Time timeFinal, Time time0) 
        {
            return new Speed(distanceFinal-distance0, timeFinal-time0);
        }
    }
}

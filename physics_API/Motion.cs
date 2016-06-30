
using physics_API.Units;

namespace physics_API
{
    public static  class Motion
    {
        public static Speed averageSpeed(Distance distanceFinal, Distance distance0,
            Time timeFinal, Time time0) 
        {
            
            if (timeFinal.Units!=time0.Units){
                throw new System.ArgumentException("time unit mismatch");
            }
            if (distanceFinal.Units != distance0.Units)
            {
                //if their diffrent convert to final units
                distanceFinal.convertTo(distance0.Units);
            }
            double dist = distanceFinal.Magnitude - distance0.Magnitude;
            double time = timeFinal.Magnitude = time0.Magnitude;
            Time.timeUnit tu = timeFinal.Units;
            Distance.distanceUnit du = distanceFinal.Units;
            return new Speed(dist / time, du, tu);
        }
    }
}

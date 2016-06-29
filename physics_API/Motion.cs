
using physics_API.Units;

namespace physics_API
{
    public static  class Motion
    {
        public static Speed averageSpeed(Distance df, Distance d0,
            Time tf, Time t0) 
        {
            double dist = df.Magnitude - d0.Magnitude;
            double time = tf.Magnitude = t0.Magnitude;
            Time.timeUnit tu = tf.Units;
            Distance.distanceUnit du = df.Units;
            return new Speed(dist / time, du, tu);
        }
    }
}

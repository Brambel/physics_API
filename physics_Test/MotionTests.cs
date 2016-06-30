using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using physics_API;
using physics_API.Units;


namespace physics_Test
{
    [TestClass]
    public class MotionTest
    {
        [TestMethod]
        public void AverageSpeed()
        {
            //check basic operation
            Distance df = new Distance(15, Distance.distanceUnit.Meter);
            Distance d0 = new Distance(10, Distance.distanceUnit.Meter);
            Time tf = new Time(10, Time.timeUnit.Second);
            Time t0 = new Time(0, Time.timeUnit.Second);
            Speed s1 = Motion.averageSpeed(df, d0, tf, t0);

            Assert.AreEqual(5, s1.Numerator.Magnitude);
            Assert.AreEqual(10, s1.Denominator.Magnitude);
            Assert.AreEqual(.5, s1.Magnitude);
            Assert.AreEqual("Meter / Second", s1.Units);

            //check internal conversion
            d0.convertTo(Distance.distanceUnit.Kilometer);
            
            s1 = Motion.averageSpeed(df, d0, tf, t0);

            Assert.AreEqual(5, s1.Numerator.Magnitude);
            Assert.AreEqual(10, s1.Denominator.Magnitude);
            Assert.AreEqual(.5, s1.Magnitude);
            Assert.AreEqual("Meter / Second", s1.Units);
        }
    }
}

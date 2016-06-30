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
            Speed temp = Motion.averageSpeed(new Distance(15, Distance.distanceUnit.Meter), new Distance(10, Distance.distanceUnit.Meter),
                new Time(0, Time.timeUnit.Second), new Time(10, Time.timeUnit.Second));
            Assert.AreEqual(.5, temp.Magnitude);
            Assert.AreEqual("Meter / Second", temp.Units);

        }
    }
}

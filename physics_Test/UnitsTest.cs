using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using physics_API.Units;

namespace physics_Test
{
    [TestClass]
    public class UnitsTest
    {
        [TestMethod]
        public void DistanceTests()
        {
            Distance d1 = new Distance(1000, Distance.distanceUnit.Milimeter);
            Distance d2 = new Distance(.001, Distance.distanceUnit.Kilometer);

            //Check conversion down
            d2.convertTo(Distance.distanceUnit.Meter);
            Assert.AreEqual(1, d2.Magnitude);
            d2.convertTo(Distance.distanceUnit.Milimeter);
            Assert.AreEqual(1000, d2.Magnitude);
            Assert.AreEqual(Distance.distanceUnit.Milimeter, d2.Units);

            //check conversion up
            d1.convertTo(Distance.distanceUnit.Kilometer);                  
            Assert.AreEqual(.001, d1.Magnitude);
            Assert.AreEqual(Distance.distanceUnit.Kilometer, d1.Units);

            //check addition
            d2.convertTo(Distance.distanceUnit.Meter);
            Distance d3 = d2 + d1;
            Assert.AreEqual(2, d3.Magnitude);                               
            Assert.AreEqual(Distance.distanceUnit.Meter, d3.Units);

            //check subtraction
            Assert.AreEqual(1, (d3 - d1).Magnitude);                        

        }

        [TestMethod]
        public void TimeTests()
        {
            Time t1 = new Time(3600, Time.timeUnit.Second);
            Time t2 = new Time(1, Time.timeUnit.Hour);

            //check conversion down
            t2.convertTo(Time.timeUnit.Minut);
            Assert.AreEqual(60.0, t2.Magnitude,0.0000001);
            Assert.AreEqual(Time.timeUnit.Minut, t2.Units);
            t2.convertTo(Time.timeUnit.Second);
            Assert.AreEqual(3600.0, t2.Magnitude, 0.0000001);
            Assert.AreEqual(Time.timeUnit.Second, t2.Units);

            //check conversion up
            t1.convertTo(Time.timeUnit.Minut);        
            Assert.AreEqual(60.0, t1.Magnitude, 0.0000001);
            Assert.AreEqual(Time.timeUnit.Minut, t1.Units);
            t1.convertTo(Time.timeUnit.Hour);
            Assert.AreEqual(1.0, t1.Magnitude, 0.0000001);
            Assert.AreEqual(Time.timeUnit.Hour, t1.Units);
            t2.convertTo(Time.timeUnit.Hour);
            Assert.AreEqual(1.0, t2.Magnitude);
            Assert.AreEqual(Time.timeUnit.Hour, t2.Units);

            //check add
            t2.convertTo(Time.timeUnit.Minut);
            Time t3 = t1 + t2;
            Assert.AreEqual(2, t3.Magnitude);
            Assert.AreEqual(Time.timeUnit.Hour, t3.Units);

            //check subtract
            t3 = t1 - t2;
            Assert.AreEqual(0, t3.Magnitude);
            Assert.AreEqual(Time.timeUnit.Hour, t3.Units);

        }

        [TestMethod]
        public void SpeedTests()
        {
            Distance d1 = new Distance(10, Distance.distanceUnit.Meter);
            Time t1 = new Time(30, Time.timeUnit.Second);
            Speed s1 = new Speed(d1, t1);
            Assert.AreEqual(1 / 3.0, s1.Magnitude,0.0000001);

        }
    }
}

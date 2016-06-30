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

        [TestMethod]
        public void FindDistanceTest()
        {
            Point p0 = new Point(0, 0);
            Point pf = new Point(5, 5);
            Point pf2 = new Point(-5, -5);
            Point pf3 = new Point(5, -5, 5);
            //check a right triangle
            Distance d = Motion.findDistance(pf, p0, Distance.distanceUnit.Meter);
            Assert.AreEqual(Math.Sqrt(25+25), d.Magnitude,0.0000001);
            Assert.AreEqual(Distance.distanceUnit.Meter, d.Units);
            //check with negitive numbers
            d = Motion.findDistance(pf2, p0, Distance.distanceUnit.Kilometer);
            Assert.AreEqual(Math.Sqrt(25 + 25), d.Magnitude, 0.0000001);
            Assert.AreEqual(Distance.distanceUnit.Kilometer, d.Units);

            //checking 3d distance
            d = Motion.findDistance(pf3, p0, Distance.distanceUnit.Kilometer);
            Assert.AreEqual(Math.Sqrt(25 + 25+ 25), d.Magnitude, 0.0000001);
            Assert.AreEqual(Distance.distanceUnit.Kilometer, d.Units);
        }

        [TestMethod]
        public void FindDistanceTraveldTest()
        {
            Point[] points = new Point[5];
            for(int i = 0; i < 5; ++i)
            {
                points[i] = new Point(i, 0);
            }
            // check a 1d motion
            Distance d = Motion.findDistanceTraveld(points, Distance.distanceUnit.Kilometer);
            Assert.AreEqual(4, d.Magnitude);
            Assert.AreEqual(Distance.distanceUnit.Kilometer, d.Units);

            //check 2d motion
            for (int i = 0; i < 5; ++i)
            {
                points[i] = new Point(i, i*2);
            }
            
            d = Motion.findDistanceTraveld(points, Distance.distanceUnit.Milimeter);
            Assert.AreEqual(8.9442719, d.Magnitude,0.0000001);
            Assert.AreEqual(Distance.distanceUnit.Milimeter, d.Units);

            //check 3d motion
            for (int i = 0; i < 5; ++i)
            {
                points[i] = new Point(i, i * 2, i*3);
            }

            d = Motion.findDistanceTraveld(points, Distance.distanceUnit.Milimeter);
            Assert.AreEqual(14.9666295, d.Magnitude, 0.0000001);
            Assert.AreEqual(Distance.distanceUnit.Milimeter, d.Units);


        }

    }
}

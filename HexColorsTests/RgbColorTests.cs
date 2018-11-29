using System;
using HexColors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HexColorsTests
{
    [TestClass]
    public class RgbColorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRgbColorFromEmptyString()
        {
            var rgbColor = RgbColor.FromString("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRgbColorFromNullString()
        {
            var rgbColor = RgbColor.FromString(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMalformedInputString()
        {
            var rgbColor = RgbColor.FromString("foo");
        }

        //validate red value input
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRedOverMaxValue()
        {
            var rgbColor = RgbColor.FromString("256,0,0");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRedBelowMinValue()
        {
            var rgbColor = RgbColor.FromString("-1,0,0");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRedNotAnInteger()
        {
            var rgbColor = RgbColor.FromString("foo,0,0");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRedEmptyValue()
        {
            var rgbColor = RgbColor.FromString(",0,0");
        }

        //validate green value input
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGreenOverMaxValue()
        {
            var rgbColor = RgbColor.FromString("0,256,0");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGreenBelowMinValue()
        {
            var rgbColor = RgbColor.FromString("0,-1,0");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGreenNotAnInteger()
        {
            var rgbColor = RgbColor.FromString("0,foo,0");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGreenEmptyValue()
        {
            var rgbColor = RgbColor.FromString("0,,0");
        }

        //validate blue value input
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBlueOverMaxValue()
        {
            var rgbColor = RgbColor.FromString("0,0,256");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBlueBelowMinValue()
        {
            var rgbColor = RgbColor.FromString("0,0,-1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBlueNotAnInteger()
        {
            var rgbColor = RgbColor.FromString("0,0,foo");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBlueEmptyValue()
        {
            var rgbColor = RgbColor.FromString("0,0,");
        }
    }
}

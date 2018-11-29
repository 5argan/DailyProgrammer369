using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HexColors
{
    public class RgbColor
    {
        public int RedValue { get; }
        public int GreenValue { get; }
        public int BlueValue { get; }

        private RgbColor(int redValue, int greenValue, int blueValue)
        {
            if (redValue < 0 || redValue > 255)
                throw new ArgumentOutOfRangeException($"Red value {redValue} not within 0 to 255.");
            if (greenValue < 0 || greenValue > 255)
                throw new ArgumentOutOfRangeException($"Red value {greenValue} not within 0 to 255.");
            if (blueValue < 0 || blueValue > 255)
                throw new ArgumentOutOfRangeException($"Red value {blueValue} not within 0 to 255.");
            RedValue = redValue;
            GreenValue = greenValue;
            BlueValue = blueValue;
        }

        public static RgbColor FromString(string rgbValues)
        {
            var values = rgbValues.Split(',');
            if (values.Length != 3)
            {
                throw new ArgumentException($"RGB '{rgbValues}' string not of form 'R,G,B'");
            }

            var rgbIntegers = new List<int>();
            foreach(var value in values)
            {
                if (int.TryParse(value, out var intValue))
                {
                    rgbIntegers.Add(intValue);
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{rgbValues} could not be parsed to integers.");
                }
            }

            return new RgbColor(rgbIntegers[0], rgbIntegers[1], rgbIntegers[2]);
        }
    }
}

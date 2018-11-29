using System;

namespace HexColors
{
    public class HexColorConverter
    {
        public string FromRGB(int red, int green, int blue)
        {
            if (red < 0 || red > 255)
                throw new ArgumentOutOfRangeException($"Red value {red} not within 0 to 255.");
            if (green < 0 || green > 255)
                throw new ArgumentOutOfRangeException($"Red value {green} not within 0 to 255.");
            if (blue < 0 || blue > 255)
                throw new ArgumentOutOfRangeException($"Red value {blue} not within 0 to 255.");
            return FormatHexString(ToHex(red), ToHex(green), ToHex(blue));
        }

        private string ToHex(int decimalValue)
        {
            return decimalValue.ToString("X");
        }

        private string FormatHexString(string redHex, string greenHex, string blueHex)
        {
            return $"#{redHex}{greenHex}{blueHex}";
        }
    }
}
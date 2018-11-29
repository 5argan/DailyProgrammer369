using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HexColors
{
    internal class HexColor
    {
        private const string HexPattern = "[0-9a-fA-F]{2}";
        private string _redValue;
        private string _greenValue;
        private string _blueValue;
        public string RedValue
        {
            get => _redValue;
            private set
            {
                var matchRed = Regex.Match(value, HexPattern);
                if (!matchRed.Success)
                    throw new ArgumentOutOfRangeException($"Red value {value} not valid 2 digit hex color code within 0 to 255.");
                _redValue = value;
            }
        }

        public string GreenValue {
            get => _greenValue;
            private set
            {
                var matchGreen = Regex.Match(value, HexPattern);
                if (!matchGreen.Success)
                    throw new ArgumentOutOfRangeException($"Green value {value} not valid 2 digit hex color code within 0 to 255.");
                _greenValue = value;
            }
        }

        public string BlueValue
        {
            get => _blueValue;
            private set
            {
                var matchBlue = Regex.Match(value, HexPattern);
                if (!matchBlue.Success)
                    throw new ArgumentOutOfRangeException($"Blue value {value} not valid 2 digit hex color code within 0 to 255.");
                _blueValue = value;
            }
        }
        public string ToString()
        {
            return $"#{RedValue}{GreenValue}{BlueValue}";
        }

        private HexColor(string redValue, string greenValue, string blueValue)
        {
            RedValue = redValue;
            GreenValue = greenValue;
            BlueValue = blueValue;
        }
        public static HexColor FromRgbColor(RgbColor rgbColor)
        {
            return new HexColor(rgbColor.RedValue.ToString("X2"), rgbColor.GreenValue.ToString("X2"), rgbColor.BlueValue.ToString("X2"));
        }
    }
}

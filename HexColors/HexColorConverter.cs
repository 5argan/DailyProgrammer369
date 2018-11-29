using System;

namespace HexColors
{
    public class HexColorConverter
    {
        public string FromRgb(RgbColor rgb)
        {
            return FormatHexString(ToHex(rgb.RedValue), ToHex(rgb.GreenValue), ToHex(rgb.BlueValue));
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
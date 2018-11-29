using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexColors
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (IsValidInput(input))
            {
                var inputColor = RgbColor.FromString(input);
                var hexColor = HexColor.FromRgbColor(inputColor);
            }
            else
            {
                Console.WriteLine("Input not valid.");
            }
        }

        private static bool IsValidInput(string input)
        {
            throw new NotImplementedException();
        }
    }
}

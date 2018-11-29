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
            var input = Console.ReadLine(); ;
            do
            {
                ProcessInput(input);
                input = Console.ReadLine();
            } while (input != "exit");
        }

        private static void ProcessInput(string input)
        {
            RgbColor inputColor;
            try
            {
                inputColor = RgbColor.FromString(input);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Input not valid.");
                return;
            }

            var hexColor = HexColor.FromRgbColor(inputColor);
            Console.WriteLine(hexColor.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Screen screen in Screen.AllScreens)
            {
                decimal mpixel = (decimal)(screen.Bounds.Width * screen.Bounds.Height) / 1000000;
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Device name: " + screen.DeviceName);
                Console.WriteLine("Is primary: " + screen.Primary);
                Console.WriteLine("Resolution: " + screen.Bounds.Width + "x" + screen.Bounds.Height + " " + mpixel + " Megapixels");
                Console.WriteLine("Bits per pixel: " + screen.BitsPerPixel);
            }
            Console.ReadKey();
        }
    }
}

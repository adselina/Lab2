using PlaginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ShowInfo
{
    [Version(3, 0)]
    public class ReverseTransform : IPlugin
    {
        public string Name
        {
            get
            {
                return "Вотермарк";
            }
        }

        public string Author
        {
            get
            {
                return "Selina AD";
            }
        }

        public void Transform(Bitmap bitmap)
        {
            Graphics graphics2 = Graphics.FromImage(bitmap);
            //graphics2.Clear(System.Drawing.Color.White);
            DateTime thisDay = DateTime.Today;
            string text = thisDay.ToString("g");
           
            graphics2.DrawString(text, new Font(FontFamily.GenericSerif, 10, FontStyle.Bold), new SolidBrush(Color.Black), bitmap.Width - 65, bitmap.Height - 20);
           
        }

        //public void Coord()
        //{
        //    GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

        //    // Do not suppress prompt, and wait 1000 milliseconds to start.
        //    watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

        //    GeoCoordinate coord = watcher.Position.Location;

        //    if (coord.IsUnknown != true)
        //    {
        //        Console.WriteLine("Lat: {0}, Long: {1}",
        //            coord.Latitude,
        //            coord.Longitude);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Unknown latitude and longitude.");
        //    }
        //}
    }
}

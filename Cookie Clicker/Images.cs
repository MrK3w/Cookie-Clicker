using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Clicker
{
    public class Images
    {
        private string[] images = {"FirstImage", "SecondImage", "ThirdImage", "FourthImage", "FifthImage"};
        public string GetImage()
        {
            Random rng = new Random();
            int i = rng.Next(0, 5);
            return images[i];
        }
    }
}

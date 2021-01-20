using System;

namespace IdleClickerEngine
{
    public class Images
    {
        private readonly string[] _images = {"FirstImage", "SecondImage", "ThirdImage", "FourthImage","FifthImage"};
        public string GetImage()
        {
            Random rng = new Random();
            int i = rng.Next(0, 5);
            return _images[i];
        }
    }
}

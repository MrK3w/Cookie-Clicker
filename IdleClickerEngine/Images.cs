using System;

namespace IdleClickerEngine
{
    public class Images
    {
        /// <summary>
        /// images for main form
        /// </summary>
        private readonly string[] _images = {"FirstImage", "SecondImage", "ThirdImage", "FourthImage","FifthImage"};
       
        /// <summary>
        /// return string of random image
        /// </summary>
        /// <returns></returns>
        public string GetImage()
        {
            Random rng = new Random();
            int i = rng.Next(0, 5);
            return _images[i];
        }
    }
}

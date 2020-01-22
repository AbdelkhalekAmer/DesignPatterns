using FlyweightPattern.Images;

using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class ImageFactory
    {
        private Dictionary<string, BaseImage> _images = new Dictionary<string, BaseImage>();

        public BaseImage GetFlyweightImage<TImage>(string imageTitle)
            where TImage : BaseImage, new()
        {
            if (_images.ContainsKey(imageTitle))
            {
                Console.WriteLine("Flyweight object.");
                return _images[imageTitle] as TImage;
            }
            else
            {
                Console.WriteLine("New object.");
                var image = new TImage();
                image.Title = imageTitle;
                _images.Add(image.Title, image);
                return image;
            }
        }

    }
}

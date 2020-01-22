using System;

namespace FlyweightPattern.Images
{
    public abstract class BaseImage
    {
        public string Title { get; set; }

        public virtual void Display(int width, int height)
        {
            Console.WriteLine($"Display: {Title} at size {width} x {height}");
        }
    }
}

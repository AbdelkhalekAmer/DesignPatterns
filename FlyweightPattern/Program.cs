using FlyweightPattern.Images;

using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageFactory = new ImageFactory();
            var image1 = imageFactory.GetFlyweightImage<ProfileImage>("Test A");
            var image2 = imageFactory.GetFlyweightImage<ProfileImage>("Test A");
            image1.Display(1, 2);
            image2.Display(10, 23);
            Console.WriteLine(ReferenceEquals(image1,image2));
        }
    }
}

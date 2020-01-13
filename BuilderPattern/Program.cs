using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamingPC = new GamingDesktopComputerBuilder()
                .WithRAM(RAMTypeEnum.DDR4, 32)
                .WithGraphicsCard(GraphicsCardManufacturerEnum.ATI, 4098)
                .GetDesktopComputer();

            var officePC = new OfficeDesktopComputer().GetDesktopComputer();

            Console.WriteLine(gamingPC);
            Console.WriteLine(officePC);
        }
    }
}

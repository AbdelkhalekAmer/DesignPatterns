using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamingPC = GetGamingDesktopComputer(new GamingDesktopComputerBuilder());
            var officePC = GetOfficeDesktopComputer(new OfficeDesktopComputer());

            Console.WriteLine(gamingPC);
            Console.WriteLine(officePC);
        }

        static DesktopComputer GetGamingDesktopComputer(IDesktopComputerBuilder desktopComputerBuilder)
        {
            desktopComputerBuilder
                .WithRAM(RAMTypeEnum.DDR4, 32)
                .WithGraphicsCard(GraphicsCardManufacturerEnum.ATI, 4098);

            return desktopComputerBuilder.GetDesktopComputer();
        }

        static DesktopComputer GetOfficeDesktopComputer(IDesktopComputerBuilder desktopComputerBuilder)
        {
            return desktopComputerBuilder.GetDesktopComputer();
        }

    }
}

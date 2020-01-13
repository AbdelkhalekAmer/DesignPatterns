namespace BuilderPattern
{
    public interface IDesktopComputerBuilder
    {
        DesktopComputer GetDesktopComputer();
        IDesktopComputerBuilder WithProcessor(string processor, double processorInGHz, int processorCount);
        IDesktopComputerBuilder WithRAM(RAMTypeEnum type, int size);
        IDesktopComputerBuilder WithGraphicsCard(GraphicsCardManufacturerEnum GraphicsCard, int memoryInMb);
        IDesktopComputerBuilder WithHardDisk(HardDiskTypeEnum type, int size);
        IDesktopComputerBuilder WithOperatingSystem(OSTypeEnum type, string version);
    }
}

namespace BuilderPattern
{
    public abstract class DesktopComputerBuilder : IDesktopComputerBuilder
    {
        protected DesktopComputer desktopComputer = new DesktopComputer();

        public DesktopComputerBuilder()
        {
            BuildProcessor();
            BuildRAM();
            BuildGraphicsCard();
            BuildHardDisk();
            BuildOperatingSystem();
        }

        public DesktopComputer GetDesktopComputer()
        {
            return desktopComputer;
        }

        public abstract IDesktopComputerBuilder WithProcessor(string processor, double processorInGHz, int processorCount);
        public abstract IDesktopComputerBuilder WithRAM(RAMTypeEnum type, int size);
        public abstract IDesktopComputerBuilder WithGraphicsCard(GraphicsCardManufacturerEnum GraphicsCard, int memoryInMb);
        public abstract IDesktopComputerBuilder WithHardDisk(HardDiskTypeEnum type, int size);
        public abstract IDesktopComputerBuilder WithOperatingSystem(OSTypeEnum type, string version);

        protected abstract void BuildProcessor();
        protected abstract void BuildRAM();
        protected abstract void BuildGraphicsCard();
        protected abstract void BuildHardDisk();
        protected abstract void BuildOperatingSystem();
    }
}

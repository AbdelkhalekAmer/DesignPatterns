namespace BuilderPattern
{
    public class GamingDesktopComputerBuilder : DesktopComputerBuilder
    {
        public override IDesktopComputerBuilder WithGraphicsCard(GraphicsCardManufacturerEnum GraphicsCard, int memoryInMb)
        {
            desktopComputer.GraphicsCard = GraphicsCard;
            desktopComputer.GraphicsCardMemoryInMb = memoryInMb;
            return this;
        }

        public override IDesktopComputerBuilder WithHardDisk(HardDiskTypeEnum type, int size)
        {
            desktopComputer.HardDiskType = type;
            desktopComputer.HardDiskSizeInGb = size;
            return this;
        }

        public override IDesktopComputerBuilder WithOperatingSystem(OSTypeEnum type, string version)
        {
            desktopComputer.OperatingSystemType = type;
            desktopComputer.OperatingSystemVersion = version;
            return this;
        }

        public override IDesktopComputerBuilder WithProcessor(string processor, double processorInGHz, int processorCount)
        {
            desktopComputer.Processor = processor;
            desktopComputer.ProcessorInGHz = processorInGHz;
            desktopComputer.ProcessorCount = processorCount;
            return this;
        }

        public override IDesktopComputerBuilder WithRAM(RAMTypeEnum type, int size)
        {
            desktopComputer.RAMType = type;
            desktopComputer.RAMSizeInGb = size;
            return this;
        }

        protected override void BuildGraphicsCard()
        {
            WithGraphicsCard(GraphicsCardManufacturerEnum.Nvidia, 4096);
        }

        protected override void BuildHardDisk()
        {
            WithHardDisk(HardDiskTypeEnum.SSD, 1024);
        }

        protected override void BuildOperatingSystem()
        {
            WithOperatingSystem(OSTypeEnum.Windows, "10");
        }

        protected override void BuildProcessor()
        {
            WithProcessor("Intel Core i7", 3.5, 8);
        }

        protected override void BuildRAM()
        {
            WithRAM(RAMTypeEnum.DDR4, 16);
        }
    }
}

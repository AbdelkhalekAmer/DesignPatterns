namespace BuilderPattern
{
    public class DesktopComputer
    {
        public string Processor { get; set; }
        public double ProcessorInGHz { get; set; }
        public int ProcessorCount { get; set; }

        public RAMTypeEnum RAMType { get; set; }
        public int RAMSizeInGb { get; set; }

        public GraphicsCardManufacturerEnum GraphicsCard { get; set; }
        public int GraphicsCardMemoryInMb { get; set; }

        public HardDiskTypeEnum HardDiskType { get; set; }
        public int HardDiskSizeInGb { get; set; }

        public OSTypeEnum OperatingSystemType { get; set; }
        public string OperatingSystemVersion { get; set; }

        public override string ToString()
        {
            return $"PC Info:\n\t>>> Processor: {Processor} - {ProcessorInGHz} GHz - {ProcessorCount} cores.\n\t" +
                $">>> RAM: {RAMType.ToString()} {RAMSizeInGb} Gb.\n\t" +
                $">>> Graphics card: {GraphicsCard.ToString()} {GraphicsCardMemoryInMb} Mb.\n\t" +
                $">>> Hard Disk: {HardDiskType.ToString()} {HardDiskSizeInGb} Gb.\n\t" +
                $">>> OS: {OperatingSystemType.ToString()} {OperatingSystemVersion}.";
        }

    }

    public enum RAMTypeEnum
    {
        DDR3,
        DDR4
    }

    public enum HardDiskTypeEnum
    {
        HDD,
        SSD
    }

    public enum GraphicsCardManufacturerEnum
    {
        Nvidia,
        ATI,
        Intel
    }

    public enum OSTypeEnum
    {
        Linux,
        Windows,
        Mac
    }

}

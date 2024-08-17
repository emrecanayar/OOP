using static SmartHomeAutomation.ComplexTypes.Enums;

namespace SmartHomeAutomation.Abstract
{
    public abstract class Device
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public DeviceStatus DeviceStatus { get; set; }

        protected Device()
        {
            Name = string.Empty;
            Model = string.Empty;
            Manufacturer = string.Empty;
            SerialNumber = string.Empty;
            Brand = string.Empty;
        }

        public override string ToString()
        {
            return "Device: " + Name + "\n" +
                   "Brand: " + Brand + "\n" +
                   "Model: " + Model + "\n" +
                   "Manufacturer: " + Manufacturer + "\n" +
                   "Serial Number: " + SerialNumber + "\n" +
                   "Status: " + DeviceStatus.ToString() + "\n";
        }

    }
}

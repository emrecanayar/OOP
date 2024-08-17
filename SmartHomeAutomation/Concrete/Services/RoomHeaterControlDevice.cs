using SmartHomeAutomation.Abstract.Services;
using static SmartHomeAutomation.ComplexTypes.Enums;

namespace SmartHomeAutomation.Concrete.Services
{
    public class RoomHeaterControlDevice : IClimateContollerDevice
    {
        private readonly RoomHeater _roomHeater;
        public RoomHeaterControlDevice(RoomHeater roomHeater)
        {
            _roomHeater = roomHeater;
        }
        public void DecreaseTemperature(int tempuratureValue)
        {
            Console.WriteLine($"Current temperature: {_roomHeater.Temperature}");
            _roomHeater.Temperature -= tempuratureValue;
            Console.WriteLine($"Brightness decrase by {tempuratureValue}. Current temperature: {_roomHeater.Temperature}");
        }

        public void IncreaseTemperature(int tempuratureValue)
        {
            Console.WriteLine($"Current brightness: {_roomHeater.Temperature}");
            _roomHeater.Temperature += tempuratureValue;
            Console.WriteLine($"Brightness increased by {tempuratureValue}. Current temperature: {_roomHeater.Temperature}");
        }

        public void TurnOfAllDevices(object sender, EventArgs e)
        {
            _roomHeater.DeviceStatus = DeviceStatus.Off;
            Console.WriteLine("All Room Heater devices turned off.");
        }

        public void TurnOff()
        {
            _roomHeater.DeviceStatus = DeviceStatus.Off;
            Console.WriteLine("Room Heater turned off.");
        }

        public void TurnOn()
        {
            _roomHeater.DeviceStatus = DeviceStatus.Off;
            Console.WriteLine("Room Heater turned on.");
        }
    }
}

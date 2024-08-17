using SmartHomeAutomation.Abstract.Services;
using static SmartHomeAutomation.ComplexTypes.Enums;

namespace SmartHomeAutomation.Concrete.Services
{
    public class LightbulbControlDevice : ISmartLightControllerDevice
    {
        private readonly Lightbulb _lightbulb;
        public LightbulbControlDevice(Lightbulb lightbulb)
        {
            _lightbulb = lightbulb;
        }
        public void DecreaseBrightness(int brightnessValue)
        {
            Console.WriteLine($"Current brightness: {_lightbulb.Brightness}");
            _lightbulb.Brightness -= brightnessValue;
            Console.WriteLine($"Brightness decreased by {brightnessValue}. Current brightness: {_lightbulb.Brightness}");
        }

        public void IncreaseBrightness(int brightnessValue)
        {
            Console.WriteLine($"Current brightness: {_lightbulb.Brightness}");
            _lightbulb.Brightness += brightnessValue;
            Console.WriteLine($"Brightness increased by {brightnessValue}. Current brightness: {_lightbulb.Brightness}");
        }

        public void TurnOfAllDevices(object sender, EventArgs e)
        {
            _lightbulb.DeviceStatus = DeviceStatus.Off;
            Console.WriteLine("All Smart light devices turned off.");
        }

        public void TurnOff()
        {
            _lightbulb.DeviceStatus = DeviceStatus.Off;
            Console.WriteLine("Smart light turned off.");
        }

        public void TurnOn()
        {
            _lightbulb.DeviceStatus = DeviceStatus.On;
            Console.WriteLine("Smart light turned on.");
        }
    }
}

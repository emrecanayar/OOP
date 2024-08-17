using SmartHomeAutomation.Abstract.Services;
using SmartHomeAutomation.Events;

namespace SmartHomeAutomation.Concrete.Services
{
    public class SmartHomeController
    {
        private readonly IClimateContollerDevice _climateControlDevice;
        private readonly ISmartLightControllerDevice _smartLightControlDevice;
        private readonly SecuritySystem _securitySystem;

        public SmartHomeController(IClimateContollerDevice climateControlDevice, ISmartLightControllerDevice smartLightControlDevice, SecuritySystem securitySystem)
        {
            _climateControlDevice = climateControlDevice;
            _smartLightControlDevice = smartLightControlDevice;
            _securitySystem = securitySystem;
        }

        public void IncreaseTemperature(int tempuratureValue)
        {
            _climateControlDevice.IncreaseTemperature(tempuratureValue);
        }

        public void DecreaseTemperature(int tempuratureValue)
        {
            _climateControlDevice.DecreaseTemperature(tempuratureValue);
        }

        public void DecreaseBrightness(int brigthnessValue)
        {
            _smartLightControlDevice.DecreaseBrightness(brigthnessValue);
        }

        public void IncreaseBrightness(int brigthnessValue)
        {
            _smartLightControlDevice.IncreaseBrightness(brigthnessValue);
        }

        public void TurnOffClimateControlDevice()
        {
            _climateControlDevice.TurnOff();
        }

        public void TurnOnClimateControlDevice()
        {
            _climateControlDevice.TurnOn();
        }

        public void TurnOnSecuritySystem()
        {
            _securitySystem.SecurityAlert += _climateControlDevice.TurnOfAllDevices;
            _securitySystem.SecurityAlert += _smartLightControlDevice.TurnOfAllDevices;
            _securitySystem.Activate();
        }
    }
}

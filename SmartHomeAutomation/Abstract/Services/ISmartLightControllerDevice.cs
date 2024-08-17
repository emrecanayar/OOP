namespace SmartHomeAutomation.Abstract.Services
{
    public interface ISmartLightControllerDevice : IControllerDevice
    {
        void IncreaseBrightness(int brightnessValue);
        void DecreaseBrightness(int brightnessValue);
    }
}

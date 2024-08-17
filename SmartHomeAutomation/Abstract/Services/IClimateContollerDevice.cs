namespace SmartHomeAutomation.Abstract.Services
{
    public interface IClimateContollerDevice : IControllerDevice
    {
        void IncreaseTemperature(int tempuratureValue);
        void DecreaseTemperature(int tempuratureValue);
    }
}

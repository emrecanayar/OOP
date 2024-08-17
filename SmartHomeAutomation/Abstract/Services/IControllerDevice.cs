namespace SmartHomeAutomation.Abstract.Services
{
    public interface IControllerDevice
    {
        void TurnOn();
        void TurnOff();
        void TurnOfAllDevices(object sender, EventArgs e);
    }
}

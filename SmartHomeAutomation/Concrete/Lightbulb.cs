using SmartHomeAutomation.Abstract;
using static SmartHomeAutomation.ComplexTypes.Enums;

namespace SmartHomeAutomation.Concrete
{
    // Lambamı temsil eden sınıf. Bu sınıf, ISmartLightDevice arayüzünü uygular. (Yani Lamba,aydınlatma tipindeki aygıtlar için.)
    public class Lightbulb : Device, ISmartLightDevice
    {
        private double _powerConsumption;
        private int _brightness;
        public LightbulbType LightbulbType { get; set; }
        public LightbulbColor LightbulbColor { get; set; }
        public double PowerConsumption
        {
            get => _powerConsumption;
            set
            {
                if (value > 0) _powerConsumption = value;
                else Console.WriteLine("Henüz tüketim olmamıştır.");
            }
        }

        public int Brightness
        {
            get => _brightness; set
            {
                if (value > 0) _brightness = value;
                else Console.WriteLine("Parlaklık değeri 0'dan küçük olamaz.");
            }
        }
    }
}

using SmartHomeAutomation.Abstract;

namespace SmartHomeAutomation.Concrete
{
    // Isıtıcımı temsil eden sınıf. Bu sınıf, IClimateDevice arayüzünü uygular. (Yani Isıtıcı,Klima tipindeki aygıtlar için.)
    public class RoomHeater : Device, IClimateDevice
    {
        private double _powerConsumption;
        private double _gasConsumption;
        private int _temperature;

        public double PowerConsumption
        {
            get => _powerConsumption;
            set
            {
                if (value > 0) _powerConsumption = value;
                else Console.WriteLine("Henüz tüketim olmamıştır.");
            }
        }

        public double GasConsumption
        {
            get => _gasConsumption;
            set
            {
                if (value > 0) _gasConsumption = value;
                else Console.WriteLine("Henüz tüketim olmamıştır.");
            }
        }

        public int Temperature
        {
            get => _temperature;
            set
            {
                if (value > 0) _temperature = value;
                else Console.WriteLine("Sıcaklık değeri 0'dan küçük olamaz.");
            }
        }
    }
}

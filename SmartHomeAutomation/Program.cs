/*
 Proje Tanımı

Bir akıllı ev yönetim sistemi geliştirdiğinizi düşünün. Bu sistemde, evde bulunan çeşitli cihazların (ısıtıcı, klima, aydınlatma, güvenlik sistemi, kamera vb.) merkezi bir kontrol paneli üzerinden yönetilmesi amaçlanıyor. Bu cihazlar, belirli zamanlarda otomatik olarak çalışabilmeli, kullanıcı tarafından manuel olarak kontrol edilebilmeli ve birbirleriyle entegre bir şekilde çalışabilmelidir.
 
 */

using SmartHomeAutomation.Concrete;
using SmartHomeAutomation.Concrete.Services;
using SmartHomeAutomation.Events;
using static SmartHomeAutomation.ComplexTypes.Enums;

Lightbulb lightbulb = new();
lightbulb.Name = "Salon Lambası";
lightbulb.PowerConsumption = 100;
lightbulb.Brightness = 50;
lightbulb.LightbulbColor = LightbulbColor.White;
lightbulb.LightbulbType = LightbulbType.LED;
lightbulb.Brand = "Philips";
lightbulb.Model = "X100";
lightbulb.SerialNumber = "1234567890";
lightbulb.Manufacturer = "Philips";

RoomHeater roomHeater = new();
roomHeater.Name = "Salon Isıtıcı";
roomHeater.PowerConsumption = 2000;
roomHeater.GasConsumption = 0;
roomHeater.Temperature = 25;
roomHeater.Brand = "Arzum";
roomHeater.Model = "AR401";
roomHeater.SerialNumber = "0987654321";
roomHeater.Manufacturer = "Arzum";



LightbulbControlDevice lightbulbControlDevice = new(lightbulb);
RoomHeaterControlDevice roomHeaterControlDevice = new(roomHeater);
SecuritySystem securitySystem = new();

SmartHomeController smartHomeController = new(roomHeaterControlDevice, lightbulbControlDevice, securitySystem);
smartHomeController.IncreaseBrightness(10);
smartHomeController.DecreaseTemperature(5);
smartHomeController.TurnOnSecuritySystem();
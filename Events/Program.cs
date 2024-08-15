// See https://aka.ms/new-console-template for more information
using Events;


// Alarm çaldığında ekrana mesaj gösteren metot.
void DisplayMessage(object sender, EventArgs e)
{
    Console.WriteLine("Good morning! It's time to wake up!");
}

// Alarm çaltığında ses çalan metot.
void PlaySound(object sender, EventArgs e)
{
    Console.WriteLine("Playing alarm sound...");
}

// Alarm çaldığında bir günlük kaydı tutan metot.
void LogEvent(object sender, EventArgs e)
{
    Console.WriteLine("Alarm event logged at: " + DateTime.Now);
}

// Alarm saatini oluşturuyoruz
var alarmClock = new AlarmClock();

// Alarm çaldığında yapılacak işlemleri event'e abone ediyoruz
alarmClock.AlarmRing += DisplayMessage;
alarmClock.AlarmRing += PlaySound;
alarmClock.AlarmRing += LogEvent;

// Alarmı çalıyoruz
alarmClock.Ring();
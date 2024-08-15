namespace Events
{
    // Alarm event'i için oluşturduğumuz delegate.
    public delegate void AlarmEventHandler(object sender, EventArgs e);
    public class AlarmClock
    {
        // Alarm çaldığında tetiklenecek olan event.
        public event AlarmEventHandler AlarmRing;

        //Alarmın çalmasını simüle edecek olan metot.
        public void Ring()
        {
            Console.WriteLine("Alarm ringing...");
            OnAlarmRing(EventArgs.Empty);
        }

        // Alarm çalındığında event'in tetiklenmesini sağlayan metot.
        protected virtual void OnAlarmRing(EventArgs e)
        {
            // Eğer event'a abone olan metotlar varsa onları tetikle.
            AlarmRing?.Invoke(this, e);
        }
    }
}

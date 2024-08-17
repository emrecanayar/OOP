namespace SmartHomeAutomation.Events
{
    public class SecuritySystem
    {
        public delegate void SecurityAlertHandler(object sender, EventArgs e);
        public event SecurityAlertHandler SecurityAlert;

        public void Activate()
        {
            Console.WriteLine("Security system activated");
            OnSecurityAlert(EventArgs.Empty);
        }


        protected virtual void OnSecurityAlert(EventArgs e)
        {
            SecurityAlert?.Invoke(this, e);
        }
    }
}

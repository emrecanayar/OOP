namespace LibraryAutomation.Concretes
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Department { get; set; }
        public short Age { get; set; }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentNumber = string.Empty;
            Department = string.Empty;
        }
    }
}

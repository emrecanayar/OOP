namespace Abstracts
{
    public class Musician
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public MusicalInstrument Instrument { get; set; } = default!;
    }
}

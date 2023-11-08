namespace DR_Records.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public Record()
        {
        }

        public Record(int id, string title, string artist, int duration, int publicationYear)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public void Validation()
        {
            ValidateTitle();
            ValidateArtist();
            ValidateDuration();
            ValidatePublicationYear();
        }

        public void ValidateTitle()
        {
            if (string.IsNullOrEmpty(Title))
            {
                throw new ArgumentNullException(nameof(Title));
            }
        }

        public void ValidateArtist()
        {
            if (string.IsNullOrEmpty(Artist)) 
            { 
                throw new ArgumentNullException(nameof(Artist));
            }
        }

        public void ValidateDuration()
        {
            if (Duration <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Duration));
            }
        }

        public void ValidatePublicationYear()
        {
            if (PublicationYear < 1000 ||  PublicationYear > DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(PublicationYear));
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Artist: {Artist}, Duration: {Duration}, Published: {PublicationYear}";
        }

    }
}

namespace RandomImagesWebAPI.Models
{
    /// <summary>
    /// This model consists of about the application properties
    /// </summary>
    public class About
    {
        public int Id { get; set; }
        public string Heading { get; set; } = string.Empty;
        public string Information { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}

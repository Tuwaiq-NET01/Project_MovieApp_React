namespace FinalProject.Models
{
    public class MovieReview
    {
        public int Id { set; get; }
        public string Text { set; get; }
        public bool Spoiler { set; get; }
        
        // Navigations properties
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
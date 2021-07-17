namespace FinalProject.Models
{
    public class TvShowReview
    {
        public int Id { set; get; }
        public string Text { set; get; }
        public bool Spoiler { set; get; }
        
        // Navigations properties
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        
        public int TvShowId { get; set; }
        public TvShow TvShow { get; set; }
    }
}
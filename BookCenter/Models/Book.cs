namespace BookCenter.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public virtual Author? Author { get; set; }
        
        public virtual ICollection<Author>? Authors { get; set;}
    }
}

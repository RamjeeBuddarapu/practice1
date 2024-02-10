namespace BookServiceWEBAPI.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public string? Author { get; set; }

        public double ISBN { get; set; }
        public string? Genre { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}

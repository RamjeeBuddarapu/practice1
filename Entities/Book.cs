using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookServiceWEBAPI.Entities
{
    [Table("Books")]
    public class Book
    {

        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Title", TypeName = "varchar")]
        public string? Title { get; set; }

        

        [Required]
        [StringLength(100)]
        [Column("Author", TypeName = "varchar")]
        public string? Author { get; set; }

        [Required]
        [Column(TypeName = "INT")]
        public double ISBN { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Genre", TypeName = "varchar")]
        public string? Genre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column("PublishDate", TypeName = "date")]
        public DateTime PublishDate { get; set; }
    }
}


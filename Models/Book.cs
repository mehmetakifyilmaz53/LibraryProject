using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        public string ISBN { get; set; }
        public string ShelfLocation { get; set; }
    }
}

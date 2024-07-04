using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        public bool IsShared { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}

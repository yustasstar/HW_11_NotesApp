using System.ComponentModel.DataAnnotations;

namespace NotesApp.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(1)]
        [MaxLength(1024)]
        public string Content { get; set; } = string.Empty;

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Last Updated")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string Tags { get; set; } = string.Empty;
    }
}

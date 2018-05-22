using System.ComponentModel.DataAnnotations;

namespace Lab8.Entity
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }
        [MaxLength(60)]
        public string Author { get; set; }
    }
}

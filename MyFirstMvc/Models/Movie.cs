using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstMvc.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 60 characters")]
        public string Title { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format")]
        [Required(ErrorMessage = "Release Date is required")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Invalid genre format")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Genre must be between 3 and 30 characters")]
        public string Genre { get; set; }

        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        [Required(ErrorMessage = "Invalid price format")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Only numbers between 0 and 5 are allowed")]
        public int Rating { get; set; }
    }
}
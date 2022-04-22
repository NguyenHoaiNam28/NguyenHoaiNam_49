using NguyenHoaiNam.Models;
using System.ComponentModel.DataAnnotations;

namespace NguyenHoaiNam.Models
{
    public class News
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(50)]
        public string Title {get; set;}
        [Required]
        public string ImageUrl {get; set;}
        [Required]
        [MaxLength(500)]
        [MinLength(100)]
        public string Content {get; set;} 
        [Required]
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        public Category Category {get; set;}
        public List<Comment> Comment {get; set;}


    }
}
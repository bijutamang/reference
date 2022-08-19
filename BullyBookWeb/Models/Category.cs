using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace BullyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="Dispaly Order must be between 1 and 100!!")]
        public int DisplayOrder { get; set; }

        public int CategoryId { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}

using System.ComponentModel.DataAnnotations;

namespace BullyBookWeb.Models
{
    public class Check
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Img { get; set; }

        public int CategoryId { get; set; }

        public Category Categories { get; set; }
    }

}

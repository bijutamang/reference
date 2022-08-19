using System.ComponentModel.DataAnnotations;

namespace BullyBookWeb.Models
{
    public class Tickets
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CName { get; set; }    

        public string SetNumber{ get; set; }
        public DateTime FliDate { get; set; } = DateTime.Now;
    }
}

namespace BullyBookWeb.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string Member_Name { get; set; }

        public string Sex { get; set; }

        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}

#nullable disable
namespace WPFNavigationTemplate.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string SessionType { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AviatorWebSite.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Phone Number")]
        public long PhoneNumber { get; set; }
    }
}

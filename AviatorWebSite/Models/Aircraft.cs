using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AviatorWebSite.Models
{
    public class Aircraft
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        public int Range { get; set; }
        public int Speed { get; set; }
        [Display(Name = "Image url/source")]
        public string Image { get; set; }
    }
}

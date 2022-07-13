using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class City
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        public int Size { get; set; }
    }
}

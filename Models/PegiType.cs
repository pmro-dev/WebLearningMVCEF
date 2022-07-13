using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class PegiType
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Value { get; set; }
        [Required]
        public string Description { get; set; }
    }
}

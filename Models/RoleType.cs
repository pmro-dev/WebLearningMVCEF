using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class RoleType
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int AccessLevel { get; set; }
    }
}

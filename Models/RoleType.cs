using System.ComponentModel;
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
        [DisplayName("Access Level")]
        public int AccessLevel { get; set; }
    }
}

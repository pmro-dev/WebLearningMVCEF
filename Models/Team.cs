using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class Team
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        public string Website { get; set; }

    }
}

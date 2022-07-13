using System.ComponentModel;

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
        [DisplayName("Short Description")]
        public string ShortDescription { get; set; }
        public string Website { get; set; }

    }
}

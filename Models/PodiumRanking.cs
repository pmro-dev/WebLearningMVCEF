using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class PodiumRanking
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Prestige Name")]
        public string PrestigeName { get; set; }
        public int Value { get; set; }
    }
}

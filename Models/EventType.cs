using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class EventType
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

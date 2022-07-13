using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class EventPlace
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CityId { get; set; }
        [Required]
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        [Required]
        public string Address { get; set; }
        [DisplayName("Post Code")]
        public int PostCode { get; set; }
        [Required]
        public int Capacity { get; set; }
        [DisplayName("Cost (Per Day)")]
        public float CostPerDay { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}

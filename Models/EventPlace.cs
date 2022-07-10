using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class EventPlace
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public int Capacity { get; set; }
        public float CostPerDay { get; set; }
        public string Owner { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}

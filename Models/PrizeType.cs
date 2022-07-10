using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class PrizeType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

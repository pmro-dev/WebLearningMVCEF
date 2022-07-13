using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class Prize
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Value { get; set; }

        public int PartnerId { get; set; }
        [ForeignKey("PartnerId")]
        public virtual Company Partner { get; set; }
        [Required]
        public int PrizeTypeId { get; set; }
        [Required]
        [ForeignKey("PrizeTypeId")]
        public virtual PrizeType Type { get; set; }
        [Required]
        public int PrizeCategoryId { get; set; }
        [ForeignKey("PrizeCategoryId")]
        [Required]
        public virtual PrizeCategory Category { get; set; }
        public int Amount { get; set; }
    }
}

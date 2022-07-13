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
        public int TypeId { get; set; }
        [Required]
        [ForeignKey("TypeId")]
        public virtual PrizeType Type { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [Required]
        public virtual PrizeCategory Category { get; set; }
        public int Amount { get; set; }
    }
}

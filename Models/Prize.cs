using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class Prize
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public int PartnerId { get; set; }
        [ForeignKey("PartnerId")]
        public virtual Company Partner { get; set; }

        public int PrizeTypeId { get; set; }
        [ForeignKey("PrizeTypeId")]
        public virtual PrizeType Type { get; set; }

        public int PrizeCategoryId { get; set; }
        [ForeignKey("PrizeCategoryId")]
        public virtual PrizeCategory Category { get; set; }
        public int Amount { get; set; }
    }
}

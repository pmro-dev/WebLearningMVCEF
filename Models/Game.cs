using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class Game
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Short Description")]
        public string ShortDescription { get; set; }
        [DisplayName("Full Description")]
        public string FullDescription { get; set; }
        public string Website { get; set; }
        [Required]
        public int GameTypeId { get; set; }
        [Required]
        [ForeignKey("GameTypeId")]
        [DisplayName("Game Type")]
        public virtual GameType Type { get; set; }
        [Required]
        public int PegiTypeId { get; set; }
        [ForeignKey("PegiTypeId")]
        public virtual PegiType Pegi { get; set; }
    }
}

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
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Website { get; set; }
        [Required]
        public int GameTypeId { get; set; }
        [Required]
        [ForeignKey("GameTypeId")]
        public virtual GameType Type { get; set; }
        [Required]
        public int PegiTypeId { get; set; }
        [ForeignKey("PegiTypeId")]
        public virtual PegiType Pegi { get; set; }
    }
}

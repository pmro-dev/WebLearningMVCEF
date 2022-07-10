using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Website { get; set; }
        public int GameTypeId { get; set; }
        [ForeignKey("GameTypeId")]
        public virtual GameType Type { get; set; }
    }
}

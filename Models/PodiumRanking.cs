using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class PodiumRanking
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrestigeName { get; set; }
        public int Value { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Size { get; set; }
    }
}

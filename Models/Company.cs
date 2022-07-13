using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class Company
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        [Required]
        public string Info { get; set; }
        public int RepresenterId { get; set; }
        [ForeignKey("RepresenterId")]
        public virtual User Representer { get; set; }
    }
}

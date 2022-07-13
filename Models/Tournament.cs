using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace WebLearningMVCEF.Models
{
    public class Tournament
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        public string LongDescription{ get; set; }
        [Required]
        public int Type { get; set; }
        public string Rules { get; set; }
        public DateTime Date{ get; set; }
        [Required]
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        [Required]
        public virtual Event Event { get; set; }


    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace WebLearningMVCEF.Models
{
    public class Tournament
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription{ get; set; }
        public int Type { get; set; }
        public File Rules { get; set; }
        public DateTime Date{ get; set; }

        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }


    }
}

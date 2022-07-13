using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class Event
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int EventTypeId { get; set; }
        [Required]
        [ForeignKey("EventTypeId")]
        public virtual EventType EventType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public DateTime Date { get; set; }
        public int Place { get; set; }

    }
}

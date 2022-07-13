using System;
using System.ComponentModel;
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
        [DisplayName("Event Type")]
        public virtual EventType EventType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Short Description")]
        public string ShortDescription { get; set; }
        [DisplayName("Full Description")]
        public string FullDescription { get; set; }
        public DateTime Date { get; set; }
        public int Place { get; set; }

    }
}

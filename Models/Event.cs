using System;
using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class Event
    {
        [Key]
       public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public DateTime Date { get; set; }
        public int Place { get; set; }

    }
}

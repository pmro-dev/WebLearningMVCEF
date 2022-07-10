namespace WebLearningMVCEF.Models
{
    public class PegiType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
    }
}

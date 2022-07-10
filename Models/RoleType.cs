namespace WebLearningMVCEF.Models
{
    public class RoleType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AccessLevel { get; set; }
    }
}

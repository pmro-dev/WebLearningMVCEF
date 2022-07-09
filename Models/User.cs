using System.ComponentModel.DataAnnotations;

namespace WebLearningMVCEF.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string Login { get; set; }
        public int RoleType_ID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Phone { get; set; }
        public int CreditCard { get; set; }
        public int Company_ID { get; set; }
        public System.DateTime DateOfLastLogin { get; set; }
        public System.DateTime DateOfAccountCreation { get; set; }
        public System.DateTime DateOfGrantedRole { get; set; }
    }
}

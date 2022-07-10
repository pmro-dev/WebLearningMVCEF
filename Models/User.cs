using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string Login { get; set; }
        public int RoleTypeId { get; set; }
        [ForeignKey("RoleTypeId")]
        public virtual RoleType RoleType { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Phone { get; set; }
        public int CreditCard { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        public DateTime DateOfLastLogin { get; set; }
        public DateTime DateOfAccountCreation { get; set; }
        public DateTime DateOfGrantedRole { get; set; }
    }
}

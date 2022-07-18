using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningMVCEF.Models
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        [DisplayName("Nick")]
        public string NickName { get; set; }
        
        [Required]
        public string Login { get; set; }

        [Required]
        public int RoleTypeId { get; set; }
        
        [ForeignKey("RoleTypeId")]
        [DisplayName("Role")]
        public virtual RoleType RoleType { get; set; }

        [Required]
        public string Password { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Second Name")]
        public string SecondName { get; set; }
        public int Phone { get; set; }
        [DisplayName("Credit Card")]
        public int CreditCard { get; set; }
        [DisplayName("Las Login Date")]
        public DateTime DateOfLastLogin { get; set; }
        [DisplayName("Account Creation Date")]
        public DateTime DateOfAccountCreation { get; set; }
        [DisplayName("Granted Role Date")]
        public DateTime DateOfGrantedRole { get; set; }
    }
}

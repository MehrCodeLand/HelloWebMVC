using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string ActiveCode { get; set; }
        [Required]
        [Display(Name = "Avatar")]
        public string Avatar { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        [Required]
        [Display(Name = "Date Created")]
        public DateTime CreateTime { get; set; }
    }
}

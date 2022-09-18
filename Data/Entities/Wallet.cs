using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Wallet
    {
        [Key]
        public int WalletId { get; set; }
        [Required]
        [Display(Name = "Descriptions")]
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }
        [Required]
        [Display(Name = "UserId")]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "WalletTypeId")]
        public int WalletTypeId { get; set; }
        public bool IsPay { get; set; }
        public DateTime CreatedTime { get; set; }



        #region F_Key

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("WalletTypeId")]
        public virtual WalletType WalletType { get; set; }

        #endregion
    }
}

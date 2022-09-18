using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class UserDiscount
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "UserId")]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "DiscountId")]
        public int DiscountId { get; set; }


        #region F_Key

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("DiscountId")]
        public virtual Discount Discount { get; set; }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class WalletType
    {
        [Key]
        public int TypeId { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string TypeTitle { get; set; }
    }
}

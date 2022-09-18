using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ConnectUs
    {
        [Key]
        public int ConnectUsId { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public int SubjectId { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }


        #region F_Key

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CourseGroup
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupTitle { get; set; }
        public bool IsDelete { get; set; }
        public int? ParentId { get; set; }


        #region F_Key

        [ForeignKey("ParentId")]
        public List<CourseGroup> courseGroups { get; set; }

        #endregion
    }
}

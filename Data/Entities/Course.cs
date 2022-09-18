using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public int GroupId { get; set; }
        public int? SubGroup { get; set; }
        public int TeacherId { get; set; }
        public int StatusId { get; set; }
        public int LevelId { get; set; }
        public string CourseTitle { get; set; }
        public string Description { get; set; }
        public int CoursePrice { get; set; }
        public string CourseImage { get; set; }
        public string DemoFileName { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }


        #region F_Key


        [ForeignKey("GroupId")]
        public virtual CourseGroup CourseGroup { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        [ForeignKey("SubGroup")]
        public virtual CourseGroup Group { get; set; }

        [ForeignKey("StatusId")]
        public virtual CourseStatus CourseStatus { get; set; }

        [ForeignKey("LevelId")]
        public virtual CourseLevel CourseLevel { get; set; }


        #endregion
    }
}

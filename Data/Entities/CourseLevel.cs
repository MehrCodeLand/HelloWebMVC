using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CourseLevel
    {
        [Key]
        public int LevelId { get; set; }
        public string LevelTitle { get; set; }
    }
}

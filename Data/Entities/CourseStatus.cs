using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CourseStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusTitle { get; set; }
    }
}

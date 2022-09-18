using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CourseEpisode
    {
        [Key]
        public int EpisodeId { get; set; }
        public int CourseId { get; set; }
        public string EpisodeTitle { get; set; }
        public TimeSpan EpisodeTime { get; set; }
        public string EpisodeFileName { get; set; }
        public bool IsFree { get; set; }

        #region F_Key

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulbaCourse.Video.Models
{
    public class Tag
    {
        public string TagId { get; set; }
        public string Content { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
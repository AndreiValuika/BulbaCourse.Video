using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulbaCourse.Video.Models
{
    public class Video
    {
        public string VideoId { get; set; }
        public int Duration { get; set; }
        public DateTime Created { get; set; }
        public int NumberOfViews { get; set; }
        public double Raiting { get; set; }
        public int SerialNumber { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
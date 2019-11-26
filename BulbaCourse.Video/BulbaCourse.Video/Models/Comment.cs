using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulbaCourse.Video.Models
{
    public class Comment
    {
        public string CommentId { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulbaCourse.Video.Models
{
    public class Course
    {
        public Course(Course course)
        {
        }
        public Course()
        {
        }
        public string CourseId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string CreatorId { get; set; }
        public CourseLevel Level { get; set; } = CourseLevel.Beginner;
        public double Raiting { get; set; }
        public string Description { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public int Duration { get; set; }
        public double Price { get; set; }

        public ICollection<Video> Videos { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
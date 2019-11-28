using BulbaCourse.Video.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BulbaCourse.Video.Repositories
{
    public static class CoursesRep
    {
        private static readonly List<Course> _courses = new List<Course>()
        {
            new Course()
            {
                Name = "Course_1",
                Level=CourseLevel.None
            },

            new Course()
            {
                Name = "Course_2",
                Level=CourseLevel.Beginner
            },

             new Course()
            {
                Name = "Course_3",
                Level=CourseLevel.Beginner
            },

             new Course()
            {
                Name = "Course_5",
                Level=CourseLevel.Advanced
            },

            new Course()
            {
                Name = "Course_6",
                Level=CourseLevel.Intermediate
            }
        };

        public static Course GetById(string id)
        {
            return _courses.SingleOrDefault(b => b.CourseId.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Course> GetAll()
        {
            return _courses.AsReadOnly(); ;
        }

        public static Course Add(Course course)
        {
            _courses.Add(course);
            return course;
        }

        public static Course Update(Course course)
        {
            var itemToRemove = _courses.SingleOrDefault(x => x.CourseId.Equals(course.CourseId,
                                                                               StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
                _courses.Remove(itemToRemove);
            _courses.Add(course);
            return course;
        }

        public static void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public static void DeleteById(string courseId)
        {
            var itemToRemove = _courses.SingleOrDefault(x => x.CourseId.Equals(courseId, 
                                                                               StringComparison.OrdinalIgnoreCase));
            _courses.Remove(itemToRemove);
        }

    }
}
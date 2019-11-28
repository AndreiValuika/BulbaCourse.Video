using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BulbaCourse.Video.Controllers
{
    [RoutePrefix("api/course")]
    public class CoursesController : ApiController
    {
        [HttpGet,Route("{id}")]
        public IHttpActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out var _))  
            {
                return BadRequest();
            }
            try
            {
                var result = Repositories.CoursesRep.GetById(id);
                return result == null ? NotFound() : (IHttpActionResult)Ok(result); 
            }
            catch (InvalidOperationException ex)
            {
                return InternalServerError(ex);
            }
            
        }
        
        [HttpGet, Route("")]
        public IHttpActionResult GetAll()
        {
            return Ok(Repositories.CoursesRep.GetAll());
        }

        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody]Models.Course course)
        {
            if (course==null ||!Enum.IsDefined(typeof(Models.CourseLevel), course.Level))
            {
                return BadRequest();
            } 

            try
            {
               var id = Repositories.CoursesRep.Add(course);
               return Ok(id);
            }

            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut, Route("{id}")]
        public IHttpActionResult Put(string id, [FromBody]Models.Course course)
        {
            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out var _))
            {
                return BadRequest();
            }

            course.CourseId = id;

            if (course == null || !Enum.IsDefined(typeof(Models.CourseLevel), course.Level))
            {
                return BadRequest();
            }

            try
            {
                Repositories.CoursesRep.Add(course);
                return Ok();
            }

            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete,Route("{id}")]
        public void Delete(string id)
        {
        }
    }
}
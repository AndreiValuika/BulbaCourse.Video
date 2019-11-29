using NUnit.Framework;
using BulbaCourse.Video.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbaCourse.Video.Controllers.Tests
{
    [TestFixture()]
    public class CoursesControllerTests
    {
        [Test]
        public void GetTest()
        {
            var testcont = new Controllers.CoursesController();
            var ter = testcont.Get("10");
            ter.ToString();
        }
    }
}
using Qiik.ExerciseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qiik.Test
{
    public class TriangleCategoryTest
    {
        [Fact]
        public void GetResult_Test()
        {
            var triangle = new TriangleCategory();
            string result = triangle.GetResult(10, 10, 10);
            Assert.Equal("Equilateral Triangle", result);
        }
    }
}

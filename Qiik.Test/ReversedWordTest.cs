using Qiik.ExerciseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qiik.Test
{
    public class ReversedWordTest
    {
        [Fact]
        public void GetResult_Test()
        {
            var reverser = new ReversedWord();
            string result = reverser.GetResult("ABCD");
            Assert.Equal("DCBA", result);
        }
    }
}

using Newtonsoft.Json.Linq;
using Qiik.ExerciseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qiik.Test
{
    public class HashingAlgorithmTest
    {
        [Fact]
        public void GetResult_Test()
        {
            var hash = new HashingAlgorithm();
            string result = hash.GetResult("Hello World");
            Assert.True(JArray.Parse(result).Count == 10);
        }
    }
}

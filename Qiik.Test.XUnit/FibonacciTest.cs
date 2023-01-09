using Qiik.ExerciseService;

namespace Qiik.Test
{
    public class FibonacciTest
    {
        [Fact]
        public void GetResult_Test()
        {
            IFibonacci fibonacci= new Fibonacci();
            string result = fibonacci.GetResult(5);
            Assert.Equal(result, "0 1 1 2 3 5");
        }
    }
}
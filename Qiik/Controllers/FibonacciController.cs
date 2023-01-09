using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qiik.ExerciseService;

namespace Qiik
{
    /// <summary>
    /// Handles fibonacci request.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        readonly IFibonacci fibonacci;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="fibonacci">DI</param>
        public FibonacciController(IFibonacci fibonacci)
        {
            this.fibonacci= fibonacci;
        }

        /// <summary>
        /// Calculate fibonacci sequence with specific length.
        /// </summary>
        /// <param name="length">Length of iteration. Must be filled greater than 0.</param>
        /// <returns>Fibonacci sequence.</returns>
        [HttpGet("{length}")]
        public ActionResult Get(int length)
        {
            return Ok(fibonacci.GetResult(length));
        }
    }
}

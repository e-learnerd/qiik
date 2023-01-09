using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qiik.ExerciseCore;
using Qiik.ExerciseService;

namespace Qiik.Controllers
{
    /// <summary>
    /// Handles triangle input.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleController : ControllerBase
    {
        readonly TriangleCategory triangle;
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="triangle">DI</param>
        public TriangleController(TriangleCategory triangle)
        {
            this.triangle = triangle;
        }

        /// <summary>
        /// Gets the triangle category name.
        /// </summary>
        /// <param name="model">Input parameter. The input values should be a valid integer.</param>
        /// <returns>Triangle category.</returns>
        [HttpPost]
        public IActionResult Post([FromBody] TriangleRequestParameter model)
        {
            return Ok(triangle.GetResult(model.FirstSide, model.SecondSide, model.ThirdSide));
        }
    }
}

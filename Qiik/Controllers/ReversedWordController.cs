using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qiik.ExerciseCore;
using Qiik.ExerciseService;

namespace Qiik.Controllers
{
    /// <summary>
    /// Hanlde reversed words.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ReversedWordController : ControllerBase
    {
        readonly ReversedWord reversedWord;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="reversedWord">DI</param>
        public ReversedWordController(ReversedWord reversedWord)
        {
            this.reversedWord = reversedWord;
        }

        /// <summary>
        /// Reverses input string.
        /// </summary>
        /// <param name="model">Input parameter. The value should be a valid string.</param>
        /// <returns>Reversed string.</returns>
        [HttpPost]
        public IActionResult Post([FromBody] RequestParameter model)
        {
            //TypedResults.Ok(model);
            return Ok(reversedWord.GetResult(model.Value));
        }
    }
}

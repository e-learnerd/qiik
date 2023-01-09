using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qiik.ExerciseCore;
using Qiik.ExerciseService;

namespace Qiik.Controllers
{
    /// <summary>
    /// Handles hashing request.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class HashingController : ControllerBase
    {
        readonly HashingAlgorithm hashing;
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="hashing">DI</param>
        public HashingController(HashingAlgorithm hashing)
        {
            this.hashing = hashing;
        }

        /// <summary>
        /// Hashes input string with various hashing algorithm.
        /// </summary>
        /// <param name="model">Input parameter. The value should be a valid string.</param>
        /// <returns>Hashed string.</returns>
        [HttpPost]
        public ActionResult Post([FromBody] RequestParameter model)
        {
            return Ok(hashing.GetResult(model.Value));
        }
    }
}

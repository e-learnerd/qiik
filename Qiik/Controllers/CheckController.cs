using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Qiik.Controllers
{
    /// <summary>
    /// Checks if the connection is well connected.
    /// </summary>
    //[Route("api/[controller]")]
    [Route("/test")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        /// <summary>
        /// Check if the API is connected.
        /// </summary>
        /// <returns>OK only.</returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("OK");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CounterController : ControllerBase
    {
        private static int count = 0;

        
        [HttpGet]
        public IActionResult GetCount()
        {
            return Ok(count); 
        }

        [HttpPost("increment")]
        public IActionResult IncrementCount()
        {
            count += 10;
            return Ok(count); 
        }
    }
}
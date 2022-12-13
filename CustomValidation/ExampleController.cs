using Microsoft.AspNetCore.Mvc;

namespace CustomValidation
{
    [Route("api/[controller]")]
    public class ExampleController : Controller
    {
        public IActionResult Post([FromBody] PersonDto item)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}

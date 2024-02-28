using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DataValidations.Controllers
{
    [ApiController]
    public class RangeExample : ControllerBase
    {
        [HttpGet("PositiveNumber/{value}")]
        public IActionResult GetPositiveNumber([Range(0, int.MaxValue)] int value)
        {
            return Ok(value);
        }
    }
}

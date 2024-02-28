using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DataValidations.Controllers
{
    [ApiController]
    public class RequiredExample : ControllerBase
    {
        public class RequiredBody
        {
            [Required]
            public string RequiredValue { get; set; } = null!;

            public string? OptionalValue { get; set; }
        }

        [HttpPost("Required")]
        public IActionResult Required([FromBody] RequiredBody body)
        {
            return Ok("Value received: " + body.RequiredValue);
        }
    }
}

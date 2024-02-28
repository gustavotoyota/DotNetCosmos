using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DataValidations.Controllers
{
    [ApiController]
    public class StringLengthExample : ControllerBase
    {
        [HttpGet("StringMaxLength4/{value}")]
        public IActionResult StringMaxLength4([StringLength(4)] string value)
        {
            return Ok(value);
        }
    }
}

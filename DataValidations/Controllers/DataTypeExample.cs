using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DataValidations.Controllers
{
    [ApiController]
    [Route("DataType")]
    public class DataTypeExample : ControllerBase
    {
        [HttpGet("EmailAddress/{value}")]
        public IActionResult GetPositiveNumber([EmailAddress] string value)
        {
            return Ok(value);
        }

        [HttpGet("Phone/{value}")]
        public IActionResult StringMaxLength4([Phone] string value)
        {
            return Ok(value);
        }
    }
}

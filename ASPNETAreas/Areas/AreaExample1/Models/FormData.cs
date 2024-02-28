using System.ComponentModel.DataAnnotations;

namespace ASPNETAreas.Areas.AreaExample1.Models
{
    public class FormData
    {
        [StringLength(10)]
        public required string Name { get; set; }

        [EmailAddress]
        public required string Email { get; set; }
    }
}

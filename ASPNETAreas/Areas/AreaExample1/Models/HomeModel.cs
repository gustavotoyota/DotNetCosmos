namespace ASPNETAreas.Areas.AreaExample1.Models
{
    public class HomeModel
    {
        public required string Title { get; set; }
        public required string Message { get; set; }

        public FormData FormData { get; set; } = null!;
    }
}

namespace SimpleRestApi.Models
{
    public class Stock
    {
        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public Stock()
        {
        }
    }
}

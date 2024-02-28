using Microsoft.AspNetCore.Mvc;
using SimpleRestApi.Models;

namespace SimpleRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StocksController : ControllerBase
    {
        private static List<Stock> _stocks = new List<Stock>
        {
            new Stock { Symbol = "MSFT", Name = "Microsoft", Price = 200 },
            new Stock { Symbol = "AAPL", Name = "Apple", Price = 300 },
            new Stock { Symbol = "GOOGL", Name = "Alphabet", Price = 1500 }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_stocks);
        }

        [HttpGet("{symbol}")]
        public IActionResult Get(string symbol)
        {
            var stock = _stocks.FirstOrDefault(s => s.Symbol == symbol);

            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock);
        }

        [HttpPost]
        public IActionResult Post(Stock stock)
        {
            _stocks.Add(stock);

            return CreatedAtAction(nameof(Get), new { symbol = stock.Symbol }, stock);
        }

        [HttpPatch("{symbol}")]
        public IActionResult Patch(string symbol, Stock stock)
        {
            var existingStock = _stocks.FirstOrDefault(s => s.Symbol == symbol);

            if (existingStock == null)
            {
                return NotFound();
            }

            if (stock.Name != null)
            {
                existingStock.Name = stock.Name;
            }

            if (stock.Price != 0)
            {
                existingStock.Price = stock.Price;
            }

            return NoContent();
        }

        [HttpDelete("{symbol}")]
        public IActionResult Delete(string symbol)
        {
            var stock = _stocks.FirstOrDefault(s => s.Symbol == symbol);

            if (stock == null)
            {
                return NotFound();
            }

            _stocks.Remove(stock);

            return NoContent();
        }
    }
}

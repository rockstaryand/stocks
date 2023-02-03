using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text.Json;
namespace StockApi.Controllers
{
    [ApiController]
    [Route("api")]
    
   
        public class ValuesController : ControllerBase
        {
            [HttpGet("Stocks")]
            public IActionResult GetFile1Data()
            {
                string content = System.IO.File.ReadAllText("Data/Stocks.json");
                var stock = JsonSerializer.Deserialize<object>(content);

                return Ok(stock);
            }

            [HttpGet("StockValues")]
            public IActionResult GetFile2Data()
            {
                string content = System.IO.File.ReadAllText("Data/StockValues.json");
                var stock = JsonSerializer.Deserialize<object>(content);

                return Ok(stock);
            }
    }
    
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Liki24.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryWindowController : ControllerBase
    {
        [HttpGet("available-windows")]
        public async Task<IEnumerable<DeliveryWindowDto>> Get(DateTime currentDate, int horizon)
        {
            return null;
        }
    }

    public class DeliveryWindowDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public bool Available { get; set; }
    }
}
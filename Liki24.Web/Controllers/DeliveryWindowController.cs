using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Liki24.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryWindowController : ControllerBase
    {
        Liki24Context dbContext;

        public DeliveryWindowController(Liki24Context dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("available-windows")]
        public async Task<IEnumerable<DeliveryWindowDto>> Get(DateTime currentDate, int horizon)
        {
            return null;
        }

        [HttpGet("get-all-settings")]
        public IEnumerable<DeliveryWindow> GetSettings()
        {
            if (!dbContext.DeliveryWindows.Any())
            {
                foreach  (var w in Seed.GetDeliveryWindows())
                    dbContext.DeliveryWindows.Add(w);

                dbContext.SaveChanges();
            }

            return dbContext.DeliveryWindows;
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
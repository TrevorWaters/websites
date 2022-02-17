using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kristinsite.Shared;

namespace kristinsite.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiteController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild Medallion", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Names = new[]
        {
            "Freezing Ring", "Bracing Bracelet", "Chilly Crown", "Cool Crest", "Mild", "Warm Watch", "Balmy Band", "Hot Hip Chain", "Sweltering Sash", "Scorching Shoulder-Length"
        };

        private readonly ILogger<SiteController> _logger;

        public SiteController(ILogger<SiteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Products> Get()
        {
            var rng = new Random();
            var counter = 0;
            return Enumerable.Range(1, Summaries.Length).Select(index => new Products
            {
                ProductID = counter++,
                Name = Names[rng.Next(Names.Length)],
                Price = rng.Next(1, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }

/*         [HttpGet]
        public Products GetProduct()
        {
            var rng = new Random();
            var counter = 0;
            return .Select(index => new Products
            {
                ProductID = counter++,
                Name = Names[rng.Next(Names.Length)],
                Price = rng.Next(1, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        } */
    }
}

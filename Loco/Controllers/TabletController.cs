using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loco.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loco.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TabletController : ControllerBase
    {
        private readonly ILogger<TabletController> _logger;

        public TabletController(ILogger<TabletController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTablets")]
        public IEnumerable<Tablet> Get()
        {
            Tablet[] tablets =
            {
                    new Tablet()
                    {
                        Id= 1, Name = "iPad", Type = "Apple"

                    },
                    new Tablet()
                    {
                        Id = 2, Name = "Tab M10 Plus", Type = "Lenovo"
                    },

                    new Tablet()
                    {
                        Id = 3, Name = "Galaxy Tab S8 Ultra", Type = "Samsung"
                    },
                    new Tablet()
                    {
                        Id = 4, Name = "MatePad T10", Type = "Huawei"
                    }
                };
            return tablets;
        }

    }
}

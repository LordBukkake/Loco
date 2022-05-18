using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Loco.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneController : ControllerBase
    {


        private readonly ILogger<PhoneController> _logger;

        public PhoneController(ILogger<PhoneController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPhones")]
        public IEnumerable<Phone> Get()
        {
            Phone[] phones =
            {
                    new Phone()
                    {
                        Id = 1, Name = "Galaxy s10", Type = "Samsung"

                    },
                    new Phone()
                    {
                        Id  = 2, Name = "Xiaomi 12 Pro", Type = "Xiaomi"
                    },

                    new Phone()
                    {
                        Id = 3, Name = "HONOR 50 Lite", Type = "HONOR"
                    },
                    new Phone()
                    {
                        Id = 4, Name = "Huawei P40 Lite", Type = "Huawei"
                    }
                };
            return phones;
        }

    }
}

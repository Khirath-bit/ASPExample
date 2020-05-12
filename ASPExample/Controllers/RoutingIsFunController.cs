using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoutingIsFunController
    {
        [HttpGet("/[controller]/routing/is/{segment}/nice")]
        public string ExampleGet(string segment, [FromQuery] string name = "anonymous")
        {
            return $"Your chosen segment was {segment} mr or mrs {name}";
        }

        [HttpPost("/[controller]/[action]")]
        public Customer GiveBody([FromBody] Customer customer)
        {
            return customer;
        }

        [HttpGet]
        public string Get()
        {
            return "Alive";
        }
    }
}

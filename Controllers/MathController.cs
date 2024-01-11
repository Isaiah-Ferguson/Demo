using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Services.MathServices;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly IMathServices _mathServices;

        public MathController(IMathServices mathServices)
        {
            _mathServices = mathServices;
        }

        [HttpGet]
        [Route("MathTime/{num}")]
        public string MathTime(string num)
        {
            return _mathServices.MathTime(num);
        }
    }
}
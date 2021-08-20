using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fizzbuzz.Services;

namespace fizzbuzz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService ?? throw new NullReferenceException("fizzBuzzService is null");
        }

        [HttpGet]
        public IEnumerable<string> Get(string param)
        {
            return _fizzBuzzService.VerifyValues(param);
        }
    }

}

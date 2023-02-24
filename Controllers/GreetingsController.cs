using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        [Route("greet")]
        public IActionResult Greetings()
        {
            //this method returns status code, Http status code
            return Ok("Hello and welcome to WebApi");
        }

        [HttpGet]
        [Route("greet/{guestName}")]
        public IActionResult Greetings(string guestName)
        {
            return Ok("Hello " + guestName);
        }

        [HttpGet]
        [Route("products")]
        public IActionResult GetProducts()
        {
            List<string> products = new()
            {
                "Pepsi", "Coke", "Iphone", "Air-pods", "Nike", "Rayban"
            };
            return Ok(products);
        }

        [HttpGet]
        [Route("calculate/{num1}/{num2}")]
        public IActionResult AddNumbers(int num1, int num2)
        {
            return Ok(num1 + num2);
        }
    }
}

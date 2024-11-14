using LuhnValidatorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LuhnValidatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LuhnValidatorController : ControllerBase
    {
        private readonly ILuhnValidator _luhnValidator;

        public LuhnValidatorController(ILuhnValidator luhnValidator)
        {
            _luhnValidator = luhnValidator;
        }

        /// <param name="cardNumber">The credit card number as a string.</param>
        /// <returns> Returns true if the credit card number is valid.</returns>
        [HttpGet("validate")]
        public IActionResult ValidateCardNumber([FromQuery] string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                return BadRequest("Card number cannot be empty.");
            }

            bool isValid = _luhnValidator.IsValid(cardNumber);
            return Ok(new { CardNumber = cardNumber, IsValid = isValid });
        }
    }
}

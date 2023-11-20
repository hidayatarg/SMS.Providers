using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NT.Sms.Models;
using NT.Sms.Services;

namespace NT.Sms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly ISmsService _smsService;

        public SmsController(ISmsService smsService)
        {
            _smsService = smsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // You can get the phone number and message from the request or any other source
            string phoneNumber = "123456789";
            string message = "Hello, this is a test SMS.";

            _smsService.SendSms(phoneNumber, message);

            return Ok("SMS sent successfully");
        }
    }
}

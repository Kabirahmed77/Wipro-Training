using Microsoft.AspNetCore.Mvc;
using FinanceBillingAnalyticsPlatform.Models;
using FinanceBillingAnalyticsPlatform.Services;
using FinanceBillingAnalyticsPlatform.Exceptions;

namespace FinanceBillingAnalyticsPlatform.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentService _paymentService = new PaymentService();

        [HttpPost]
        public IActionResult MakePayment([FromBody] Payment payment)
        {
            try
            {
                _paymentService.MakePayment(payment);
                return Ok("Payment processed successfully");
            }
            catch (BillingException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
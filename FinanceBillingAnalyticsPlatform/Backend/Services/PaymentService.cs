using FinanceBillingAnalyticsPlatform.Models;
using FinanceBillingAnalyticsPlatform.Repositories;
using FinanceBillingAnalyticsPlatform.Exceptions;
using System.Linq;

namespace FinanceBillingAnalyticsPlatform.Services
{
    public class PaymentService
    {
        private readonly InvoiceRepository _invoiceRepo = new InvoiceRepository();
        private readonly InvoiceRepository _paymentRepo = new InvoiceRepository(); // Using InvoiceRepository for storage, no separate IPaymentRepository

        public void MakePayment(Payment payment)
        {
            var invoice = _invoiceRepo.GetById(payment.InvoiceId);

            if (invoice == null)
                throw new BillingException("Invoice not found");

            if (invoice.Status == "Paid")
                throw new BillingException("Invoice already paid");

            if (payment.AmountPaid <= 0)
                throw new BillingException("Payment amount must be greater than zero");

            
            invoice.Status = "Paid";

            
            _paymentRepo.Add(new Models.Invoice
            {
                InvoiceId = payment.InvoiceId,
                CustomerId = invoice.CustomerId,
                Amount = payment.AmountPaid,
                Status = "Paid"
            });
        }
    }
}
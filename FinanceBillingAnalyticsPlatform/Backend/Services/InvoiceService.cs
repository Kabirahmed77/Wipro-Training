using FinanceBillingAnalyticsPlatform.Models;
using FinanceBillingAnalyticsPlatform.Repositories;
using FinanceBillingAnalyticsPlatform.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace FinanceBillingAnalyticsPlatform.Services
{
    public class InvoiceService
    {
        private readonly InvoiceRepository _invoiceRepo = new InvoiceRepository();

        public List<Invoice> GetInvoices()
        {
            return _invoiceRepo.GetAll();
        }

        public void CreateInvoice(Invoice invoice)
        {
            if (_invoiceRepo.GetAll().Any(i => i.InvoiceId == invoice.InvoiceId))
                throw new BillingException("Duplicate Invoice ID");

            if (invoice.Amount <= 0)
                throw new BillingException("Invoice amount must be greater than zero");

            _invoiceRepo.Add(invoice);
        }
    }
}
using FinanceBillingAnalyticsPlatform.Interfaces;
using FinanceBillingAnalyticsPlatform.Models;
using System.Collections.Generic;
using System.Linq;

namespace FinanceBillingAnalyticsPlatform.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private static List<Invoice> invoices = new List<Invoice>();

        public List<Invoice> GetAll()
        {
            return invoices;
        }

        public void Add(Invoice invoice)
        {
            invoices.Add(invoice);
        }

        public Invoice GetById(int id)
        {
            return invoices.FirstOrDefault(i => i.InvoiceId == id);
        }
    }
}
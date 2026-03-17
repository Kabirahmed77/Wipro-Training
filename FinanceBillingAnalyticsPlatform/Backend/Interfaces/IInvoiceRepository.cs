using FinanceBillingAnalyticsPlatform.Models;
using System.Collections.Generic;

namespace FinanceBillingAnalyticsPlatform.Interfaces
{
    public interface IInvoiceRepository
    {
        List<Invoice> GetAll();
        void Add(Invoice invoice);
        Invoice GetById(int id);
    }
}
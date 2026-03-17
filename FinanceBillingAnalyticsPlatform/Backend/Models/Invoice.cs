namespace FinanceBillingAnalyticsPlatform.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Pending"; // Default status
    }
}
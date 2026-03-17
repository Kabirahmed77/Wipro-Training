using System;

namespace FinanceBillingAnalyticsPlatform.Exceptions
{
    public class BillingException : Exception
    {
        public BillingException(string message) : base(message)
        {
        }
    }
}
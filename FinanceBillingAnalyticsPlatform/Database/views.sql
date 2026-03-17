USE FinanceBillingDB;
GO

CREATE VIEW vw_BillingSummary AS
SELECT c.Name, SUM(i.Amount) as TotalBilled
FROM Customers c 
JOIN Invoices i ON c.CustomerId = i.CustomerId
GROUP BY c.Name;
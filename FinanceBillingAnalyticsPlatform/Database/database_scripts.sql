USE FinanceBillingDB;
GO

-- Clean up just in case the table was partially created
IF OBJECT_ID('Payments', 'U') IS NOT NULL DROP TABLE Payments;
GO

-- 1.the Payments Table 
CREATE TABLE Payments (
    PaymentId INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceId INT NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(),
    AmountPaid DECIMAL(18,2) NOT NULL,
    PaymentMethod VARCHAR(50),
    FOREIGN KEY (InvoiceId) REFERENCES Invoices(InvoiceId)
);
GO

-- 2.the Analytics View(Fixed: Using CustomerId instead of Id)
CREATE VIEW vw_OutstandingInvoices AS
SELECT c.Name AS CustomerCompany, i.InvoiceId, i.Amount AS TotalDue, i.DueDate, i.Status
FROM Invoices i
JOIN Customers c ON i.CustomerId = c.CustomerId
WHERE i.Status IN ('Pending', 'Overdue');
GO

-- 3.Monthly Report Stored Procedure
CREATE PROCEDURE sp_GenerateMonthlyReport
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT COUNT(InvoiceId) AS TotalInvoices, SUM(Amount) AS TotalBilled, Status
    FROM Invoices
    WHERE MONTH(DueDate) = @Month AND YEAR(DueDate) = @Year
    GROUP BY Status;
END;
GO
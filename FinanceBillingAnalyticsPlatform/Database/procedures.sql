USE FinanceBillingDB;
GO

CREATE PROCEDURE sp_GetInvoicesByCustomer @CustId INT
AS BEGIN
    SELECT * FROM Invoices WHERE CustomerId = @CustId;
END;
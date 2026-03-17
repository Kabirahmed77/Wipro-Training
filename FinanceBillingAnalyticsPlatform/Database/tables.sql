USE FinanceBillingDB;
GO

CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY,
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);

CREATE TABLE Invoices (
    InvoiceId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId),
    Amount DECIMAL(18,2),
    DueDate DATETIME,
    Status NVARCHAR(20) DEFAULT 'Pending'
);
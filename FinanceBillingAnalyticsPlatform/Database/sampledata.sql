USE FinanceBillingDB;
GO

INSERT INTO Customers (CustomerId, Name, Email) 
VALUES (101, 'Kabir', 'kabir@sritcbe.ac.in');

INSERT INTO Invoices (CustomerId, Amount, DueDate) 
VALUES (101, 1500.50, '2026-04-15');
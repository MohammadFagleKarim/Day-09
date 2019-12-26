CREATE DATABASE CoffeeShop

USE CoffeeShop

CREATE TABLE Items (
ItemId INT IDENTITY(1,1),
ItemName VARCHAR(50) UNIQUE, 
Price DOUBLE PRECISION
)

--DROP TABLE Items
--DROP TABLE Customers

--INSERT INTO Items (Name, Price) VALUES ('BLACK COFFEE', 120)
--INSERT INTO Items (Name, Price) VALUES ('COLD COFFEE', 100)
--INSERT INTO Items (Name, Price) VALUES ('REGULAR COFFEE', 80)
--INSERT INTO Items (Name, Price) VALUES ('REGULAR COFFEE', 80)

SELECT * FROM Items

--UPDATE Items
--SET Name = 'HOT COFFEE', Price = 90 WHERE ID = 3

--DELETE FROM Items WHERE ID = 6

--UPDATE Items
--SET Name = 'HOT COFFEE', Price = 90 WHERE ID = 3

--DELETE FROM Items WHERE ID = 6

CREATE TABLE Customers (
CustomerId INT IDENTITY(1000, 1),
CustomerName VARCHAR(30) UNIQUE,
Contact VARCHAR(11) UNIQUE,
Address VARCHAR(MAX))

--INSERT INTO Customers(CustomerName, Contact, Address) VALUES ('KARIM', 20, '01684550302', 'MIRPUR')
--INSERT INTO Customers(CustomerName, Contact, Address) VALUES ('SABBIR', 22, '01728803979', 'MIRPUR')
--INSERT INTO Customers(CustomerName, Contact, Address) VALUES ('HABIB', 30, '01315911950', 'SYAMOLI')
--INSERT INTO Customers(CustomerName, Contact, Address) VALUES ('SHANTO', 18, '01315911953', 'DHANMONDI')
--INSERT INTO Customers(CustomerName, Contact, Address) VALUES ('SAGAR', 30, '01315911950', 'SAGOPTA')

SELECT * FROM Customers

SELECT ItemName, Price FROM Items
ORDER BY ItemName, Price

SELECT ItemName, Price FROM Items
WHERE Price<100

CREATE TABLE Orders (
OrderId INT IDENTITY(1,1),
ItemName VARCHAR(30) UNIQUE,
Quantity INT,
TotalPrice DOUBLE PRECISION,
CustomerName VARCHAR(30))

INSERT INTO Orders(ItemName, Quantity, TotalPrice, CustomerName) VALUES ('BLACK COFFEE', 120.0, 'KARIM')
INSERT INTO Orders(ItemName, Quantity, TotalPrice, CustomerName) VALUES ('HOT COFFEE', 100.0, 'SABBIR')
INSERT INTO Orders(ItemName, Quantity, TotalPrice, CustomerName) VALUES ('COLD COFFEE', 150.0, 'EMON')
INSERT INTO Orders(ItemName, Quantity, TotalPrice, CustomerName) VALUES ('REGULAR COFFEE', 80.0, 'SHETU')

SELECT * FROM Orders


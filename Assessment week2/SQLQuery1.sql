CREATE DATABASE SQLAssessment;

GO
CREATE SCHEMA SQLAssessmentDb;
GO

--DROP TABLE Customers;
CREATE TABLE Customers(
	CustomerId INT NOT NULL IDENTITY,
	FirstName NVARCHAR(200) NOT NULL,
	LastName NVARCHAR(200) NOT NULL,
	Cardnumber INT,
	CONSTRAINT PK_CustomerId PRIMARY KEY (CustomerId)
);

--DROP TABLE Products;
CREATE TABLE Products(
	ProductId INT NOT NULL IDENTITY,
	Name NVARCHAR(200) NOT NULL,
	Price MONEY NOT NULL,
	CONSTRAINT PK_ProductId PRIMARY KEY (ProductId)
);

--DROP TABLE Orders;
CREATE TABLE Orders(
	OrderId INT NOT NULL IDENTITY,
	CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId),
	ProductId INT FOREIGN KEY REFERENCES Products(ProductId)
);

INSERT INTO Customers (FirstName, LastName, Cardnumber) VALUES
	('John','Smith', 12345678);

INSERT INTO Customers ( FirstName, LastName, Cardnumber) VALUES
	('Jane','Smith', 87654321 );

INSERT INTO Customers ( FirstName, LastName, Cardnumber) VALUES
	('Jake','Lane', 24680246);

INSERT INTO Products (Name, Price) VALUES
	('Notebook', 1);

INSERT INTO Products (Name, Price) VALUES
	('Pen', 15);

INSERT INTO Products (Name, Price) VALUES
	('Textbook', 1000);

INSERT INTO Orders (CustomerId, ProductId) VALUES
	(1, 3);

INSERT INTO Orders (CustomerId, ProductId) VALUES
	(2, 3);

INSERT INTO Orders (CustomerId, ProductId) VALUES
	(2, 2);

INSERT INTO Orders (CustomerId, ProductId) VALUES
	(3, 1);

INSERT INTO Products (Name, Price) VALUES
	('iPhone', 200);

INSERT INTO Customers (FirstName, LastName) VALUES
	('Tina','Smith');

INSERT INTO Orders (CustomerId, ProductId) VALUES
	(4, 4);

--INSERT INTO Orders (CustomerId, ProductId) VALUES
--	(4, 1);

SELECT Customers.FirstName, Customers.LastName, Products.Name
FROM Customers
	LEFT JOIN Orders ON Customers.CustomerId = Orders.CustomerId
	LEFT JOIN Products On Products.ProductId = Orders.ProductId
WHERE Customers.FirstName = 'Tina' AND Customers.LastName = 'Smith';

SELECT Products.Name, Customers.FirstName, Customers.LastName
FROM Products
	LEFT JOIN Orders ON Products.ProductId = Orders.ProductId
	LEFT JOIN Customers ON Orders.CustomerId = Customers.CustomerId
WHERE Products.Name = 'iPhone';

UPDATE Products
SET Price = 250
WHERE ProductId = 4;

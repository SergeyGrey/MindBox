--CREATE TABLE Products (
--	Id INT PRIMARY KEY,
--	"Name" TEXT
--);

--CREATE TABLE Categories (
--	Id INT PRIMARY KEY,
--	"Name" TEXT
--);

--CREATE TABLE ProductCategories (
--	ProductId INT FOREIGN KEY REFERENCES Products(Id),
--	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
--	PRIMARY KEY (ProductId, CategoryId)
--);

--INSERT INTO Products
--VALUES
--	(1, 'Apple'),
--	(2, 'Car'),
--	(3, 'Pen'),
--	(4, 'Coin'),
--	(5, 'Belt'),
--	(6, 'Hen'),
--	(7, 'Kitten'),
--	(8, 'Orange');

--INSERT INTO Categories
--VALUES
--	(1, 'Fruits'),
--	(2, 'Metal'),
--	(3, 'Zoo'),
--	(4, 'Tasty');

--INSERT INTO ProductCategories
--VALUES
--	(1, 1),
--	(1, 4),
--	(2, 2),
--	(3, 2),
--	(4, 2),
--	(6, 3),
--	(6, 4),
--	(7, 3),
--	(8, 1);

SELECT Products.Name, Categories.Name
FROM Products 
LEFT JOIN ProductCategories 
	ON Products.Id = ProductCategories.ProductId
LEFT JOIN Categories
	ON ProductCategories.CategoryId = Categories.Id;
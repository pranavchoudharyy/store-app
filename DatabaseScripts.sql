-- -- create database ChoudharyDB;
-- -- use ChoudharyDB;
-- drop database ChoudharyDB
CREATE TABLE Categories
(
    CategoryId TINYINT CONSTRAINT pk_CategoryId PRIMARY KEY IDENTITY,
    CategoryName VARCHAR(20) CONSTRAINT uq_CategoryName UNIQUE NOT NULL
)
GO
-- INSERT INTO Categories VALUES ('Motors')
-- INSERT INTO Categories VALUES ('Fashion')
-- SELECT * FROM Categories

CREATE TABLE Products(
    ProductId CHAR(4) CONSTRAINT pk_ProductId PRIMARY KEY CONSTRAINT chk_ProductId CHECK(ProductId LIKE 'P%'),
    ProductName VARCHAR(20) UNIQUE NOT NULL,
    CategoryId TINYINT CONSTRAINT fk_CategoryId REFERENCES Categories(CategoryId),
    Price NUMERIC(8) CONSTRAINT chk_Price CHECK (Price>0) NOT NULL,
    QuantityAvailable INT CONSTRAINT chk_QuantityAvailable CHECK (QuantityAvailable>0) NOT NULL
)
GO
-- INSERT INTO Products(ProductId,ProductName,CategoryId,Price,QuantityAvailable) VALUES('P101','Lambo',1,18000000.00,10)
-- Select * from Products
-- drop table Products

CREATE TABLE Customers(
    EmailId VARCHAR(50) CONSTRAINT pk_EmailId PRIMARY KEY,
    CustomerPassword VARCHAR(15) NOT NULL,
    Gender CHAR(1) CONSTRAINT chk_Gender CHECK (Gender IN ('F','M')),
    DateOfBirth DATE CONSTRAINT chk_DateOfBirth CHECK (DateOfBirth<GetDate()) NOT NULL,
    [Address] VARCHAR(200) NOT NULL
)
GO
-- INSERT INTO Customers( EmailId,CustomerPassword,Gender, DateOfBirth,Address) VALUES('Davis@gmail.com','WOLZA@1234','M','1982-01-09','ul. Filtrowa 68')
-- SELECT * from Customers

CREATE TABLE Orders(
    PurchaseId BIGINT CONSTRAINT pk_PurchaseId PRIMARY KEY IDENTITY,
    EmailId VARCHAR(50) CONSTRAINT fk_EmailId REFERENCES Customers(EmailId),
    ProductId CHAR(4) CONSTRAINT fk_ProductId REFERENCES Products(ProductId),
    QuantityPurchased SMALLINT CONSTRAINT chk_QuantityPurchased CHECK(QuantityPurchased>0)NOT NULL,
    DateOfPurchase SMALLDATETIME CONSTRAINT chk_DateOfPurchase CHECK(DateOfPurchase<GetDate())NOT NULL
) 
GO
-- SET IDENTITY_INSERT Orders OFF
-- INSERT INTO Orders(PurchaseId,EmailId,ProductId,QuantityPurchased,DateOfPurchase) VALUES(1001,'Davis@gmail.com','P101',2,'Jan 12 2014 12:00AM')
-- Select * from Orders
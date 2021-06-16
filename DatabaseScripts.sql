-- create database ChoudharyDB;
-- use ChoudharyDB;
-- drop database ChoudharyDB
CREATE TABLE Categories
(
    CategoryId INT CONSTRAINT pk_CategoryId PRIMARY KEY IDENTITY,
    HSNCode INT ,
    CategoryName VARCHAR(20) CONSTRAINT uq_CategoryName UNIQUE NOT NULL
)
GO
drop table Categories
INSERT INTO Categories VALUES (2329 , 'Cement')
INSERT INTO Categories VALUES (2330, 'Iron')
SELECT * FROM Categories

CREATE TABLE Products(
    ProductId CHAR(4) CONSTRAINT pk_ProductId PRIMARY KEY CONSTRAINT chk_ProductId CHECK(ProductId LIKE 'P%'),
    ProductName VARCHAR(20) UNIQUE NOT NULL,
    CategoryId INT CONSTRAINT fk_CategoryId REFERENCES Categories(CategoryId),
    Price NUMERIC(8) CONSTRAINT chk_Price CHECK (Price>0) NOT NULL,
    QuantityAvailable INT CONSTRAINT chk_QuantityAvailable CHECK (QuantityAvailable>0) NOT NULL
)
GO
-- drop table Products
-- INSERT INTO Products(ProductId,ProductName,CategoryId,Price,QuantityAvailable) VALUES('P104','Tehri TMT BAR 12MM',2,5900.00,30.00)
Select * from Products
-- drop table Products

CREATE TABLE Customers(
    [Name] VARCHAR(50),
    EmailId VARCHAR(50) CONSTRAINT pk_EmailId PRIMARY KEY,
    CustomerPassword VARCHAR(15) NOT NULL,
    Gender CHAR(1) CONSTRAINT chk_Gender CHECK (Gender IN ('F','M')),
    DateOfBirth DATE CONSTRAINT chk_DateOfBirth CHECK (DateOfBirth<GetDate()) NOT NULL,
    [Address] VARCHAR(200) NOT NULL,
    Phone NUMERIC 
)
GO
drop table Customers
INSERT INTO Customers VALUES('Pranav Choudhary','beniwalpranav@gmail.com','Pranav@123','M','2000-01-01','Thanabhawan',9997973370)
INSERT INTO Customers VALUES('Aniket Choudhary','aniket@gmail.com','Aniket@123','M','2000-07-11','Thanabhawan',8218329410)

SELECT * from Customers

CREATE TABLE Orders(
    PurchaseId BIGINT CONSTRAINT pk_PurchaseId PRIMARY KEY IDENTITY,
    EmailId VARCHAR(50) CONSTRAINT fk_EmailId REFERENCES Customers(EmailId),
    ProductId CHAR(4) CONSTRAINT fk_ProductId REFERENCES Products(ProductId),
    QuantityPurchased SMALLINT CONSTRAINT chk_QuantityPurchased CHECK(QuantityPurchased>0)NOT NULL,
    DateOfPurchase SMALLDATETIME CONSTRAINT chk_DateOfPurchase CHECK(DateOfPurchase<GetDate())NOT NULL
) 
GO
-- drop table Orders
SET IDENTITY_INSERT Orders ON
INSERT INTO Orders(PurchaseId,EmailId,ProductId,QuantityPurchased,DateOfPurchase) VALUES(1001,'beniwalpranav@gmail.com','P100',5,'2021-05-14')
Select * from Orders
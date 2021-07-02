CREATE TABLE Categories
(
    CategoryId INT CONSTRAINT pk_CategoryId PRIMARY KEY IDENTITY,
    HSNCode INT ,
    CategoryName VARCHAR(20) CONSTRAINT uq_CategoryName UNIQUE NOT NULL
)
GO
-- drop table Categories
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
INSERT INTO Products(ProductId,ProductName,CategoryId,Price,QuantityAvailable) VALUES('P100','Acc Suraksha',1,390.00,800)
INSERT INTO Products(ProductId,ProductName,CategoryId,Price,QuantityAvailable) VALUES('P101','Acc Concrete+',1,425.00,500)
INSERT INTO Products(ProductId,ProductName,CategoryId,Price,QuantityAvailable) VALUES('P102','Acc Gold',1,460.00,300)
INSERT INTO Products(ProductId,ProductName,CategoryId,Price,QuantityAvailable) VALUES('P103','Tehri TMT BAR 10 MM',2,6150.00,20)
INSERT INTO Products(ProductId,ProductName,CategoryId,Price,QuantityAvailable) VALUES('P104','Tehri TMT BAR 12 MM',2,5900.00,30)

Select * from Products
-- drop table Products

CREATE TABLE Customers
(
    [First Name] VARCHAR(50) NOT NULL,
    [Last Name] VARCHAR(50) NOT NULL,
    EmailId VARCHAR(50) CONSTRAINT pk_EmailId PRIMARY KEY NOT NULL,
    [Secondary EmailId] VARCHAR(50),
    CustomerPassword VARCHAR(15) NOT NULL,
    Phone NUMERIC NOT NULL,
    [Secondary Phone] NUMERIC,
    Gender CHAR(1) CONSTRAINT chk_Gender CHECK (Gender IN ('F','M')),
    DateOfBirth DATE CONSTRAINT chk_DateOfBirth CHECK (DateOfBirth<GetDate()) NOT NULL,
    [Address] VARCHAR(200)
)
GO
-- drop table Customers
INSERT INTO Customers VALUES('Pranav','Choudhary','beniwalpranav@gmail.com','','Pranav@123',9997973370,9997977033,'M','2000-01-01','Thanabhawan')
-- INSERT INTO Customers VALUES('Aniket Choudhary','aniket@gmail.com','Aniket@123','M','2000-07-11','Thanabhawan',8218329410)

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
-- SET IDENTITY_INSERT Orders OFF
INSERT INTO Orders VALUES('beniwalpranav@gmail.com','P100',5,'2021-05-14')
Select * from Orders
-- TRUNCATE table Orders

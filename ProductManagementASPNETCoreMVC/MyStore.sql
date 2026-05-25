-- Tạo Database
CREATE DATABASE MyStore;
GO

USE MyStore;
GO

-- Tạo bảng AccountMember
CREATE TABLE AccountMember (
    MemberID nvarchar(20) NOT NULL PRIMARY KEY,
    MemberPassword nvarchar(80) NOT NULL,
    FullName nvarchar(80) NOT NULL,
    EmailAddress nvarchar(100) NOT NULL,
    MemberRole int NOT NULL
);
GO

-- Tạo bảng Categories
CREATE TABLE Categories (
    CategoryID int NOT NULL PRIMARY KEY,
    CategoryName nvarchar(15) NOT NULL
);
GO

-- Tạo bảng Products
CREATE TABLE Products (
    ProductID int NOT NULL PRIMARY KEY,
    ProductName nvarchar(40) NOT NULL,
    CategoryID int NOT NULL,
    UnitsInStock smallint NULL,
    UnitPrice money NULL,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
GO
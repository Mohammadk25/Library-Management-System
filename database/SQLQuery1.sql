CREATE TABLE Staff (
    Staff_ID INT ,
    StaffUsername NVARCHAR(50) ,
    StaffPassword NVARCHAR(50)
);
CREATE TABLE Supplier (
    SupplierID INT ,
    SupplierUsername NVARCHAR(50) ,
    SupplierPassword NVARCHAR(50) 
);
CREATE TABLE Book (
       Title NVARCHAR(100),
    Quantity INT,
    Reserved BIT  DEFAULT 0
);
CREATE TABLE Member (
    MemberID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50)
);  
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) ,
    Password NVARCHAR(50) ,
        BooksBorrowed INT NULL
);


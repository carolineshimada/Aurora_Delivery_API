CREATE TABLE Customer (
    Id BIGINT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    Phone VARCHAR(15),
    Email VARCHAR(100),
    Password VARCHAR(100)
);

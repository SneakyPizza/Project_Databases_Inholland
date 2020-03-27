CREATE DATABASE [ProjectDatabase];
GO
USE [ProjectDatabase];

CREATE TABLE Person(
    PersonID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Firstname nvarchar(20) NOT NULL,
    Lastname nvarchar(20) NOT NULL,
    Email nvarchar(40) NOT NULL,
    Phonenumber nvarchar(13) NOT NULL,
    [Role] int NOT NULL
);

CREATE TABLE [Order](
    OrderID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    PersonID int NOT NULL FOREIGN KEY REFERENCES Person(PersonID),
    Amount int NOT NULL,
    --ProductID int NOT NULL FOREIGN KEY REFERENCES Product(ID),
    [Timestamp] datetime NOT NULL,
);

CREATE TABLE Room (
    RoomID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    PersonID int NOT NULL FOREIGN KEY REFERENCES Person(PersonID),
    RoomType nvarchar(20) NOT NULL,
	RoomCapacity int NOT NULL
);

CREATE TABLE [Event](
    EventID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    --ActivityID int NOT NULL FOREIGN KEY REFERENCES Activity(ID),
    [Date] datetime NOT NULL,
    [Description] nvarchar(30) NOT NULL,
    SupervisorID int NOT NULL FOREIGN KEY REFERENCES Person(PersonID)
    --EventJunctionID int NOT NULL FOREIGN KEY REFERENCES EventJunction(ID)
);

CREATE TABLE Sales(
    salesID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    orderId int NOT NULL FOREIGN KEY REFERENCES [Order](OrderID),
    Price money NOT NULL,
    [Date] datetime NOT NULL,
    InputDate datetime NOT NULL
);

CREATE TABLE Activity(
    ActivityID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] nvarchar(30) NOT NULL,
    [Date] datetime NOT NULL,
    [Description] nvarchar(30) NOT NULL
    );

CREATE TABLE Product(
    ProductID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] nvarchar(20) NOT NULL,
    Price money NOT NULL,
    BTWPercentile int NOT NULL,
    Amount int NOT NULL,
    [Description] nvarchar(30)
);

CREATE TABLE [EventJunction](
    EventJunctionID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    PersonID int NOT NULL FOREIGN KEY REFERENCES Person(PersonID),
    EventID int NOT NULL FOREIGN KEY REFERENCES [Event](EventID)
);

ALTER TABLE [Order]
	ADD ProductID int NOT NULL FOREIGN KEY REFERENCES Product(ProductID);

ALTER TABLE [Event]
	ADD CONSTRAINT ActivityID FOREIGN KEY (EventID) REFERENCES Activity(ActivityID),
        CONSTRAINT EventJunctionID FOREIGN KEY (EventID) REFERENCES EventJunction(EventJunctionID);
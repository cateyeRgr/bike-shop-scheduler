--create database Terminerstellung;

--USE Terminerstellung
--GO

--CREATE TABLE Staff (
--StaffID INT IDENTITY PRIMARY KEY,
--LastName varchar(100) NOT NULL,
--FirstName varchar(100) NOT NULL,
--Wage MONEY NOT NULL,
--Hours DECIMAL(7,2) NOT NULL,
--Supervisor INT
--);

--CREATE TABLE Customer (
--CustomerID INT IDENTITY PRIMARY KEY,
--LastName varchar(100) NOT NULL,
--FirstName varchar(100) NOT NULL,
--Postleitzahl INT NOT NULL,
--Ort varchar(100) NOT NULL,
--Straﬂe varchar(100) NOT NULL,
--Hausnummer varchar(100) NOT NULL
--);


--Create Table Workshop (
--WorkshopID int IDENTITY PRIMARY KEY,
--Name varchar(100),
--Postleitzahl INT NOT NULL,
--Ort varchar(100) NOT NULL,
--Straﬂe varchar(100) NOT NULL,
--Hausnummer varchar(100) NOT NULL
--);


--CREATE TABLE Appointment (
--AppointmentID INT IDENTITY PRIMARY KEY,
--Date DATETIME  NOT NULL, 
--Length DECIMAL(7,2) NOT NULL,
--AppointmentPrice MONEY NOT NULL,
--CustomerID int,
--FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
--WorkshopID int,
--FOREIGN KEY (WorkshopID) REFERENCES Workshop(WorkshopID)
--);

--CREATE TABLE Bike (
--BikeID INT IDENTITY PRIMARY KEY,
--SerialNumber int NOT NULL,
--CustomerID int,
--FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
--);

--CREATE TABLE Hardware (
--HardwareID INT IDENTITY PRIMARY KEY,
--HardwareName varchar(100),
--HardwarePrice MONEY NOT NULL
--);


--CREATE TABLE Repair (
--RepairID INT IDENTITY PRIMARY KEY,
--RepairDetails varchar(100),
--RepairPrice MONEY NOT NULL
--);


--CREATE TABLE AppointmentStaff (
--AppointmentID int,
--FOREIGN KEY (AppointmentID) REFERENCES Appointment(AppointmentID),
--StaffID int,
--FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
--);


--CREATE TABLE HardwareRepair (
--HardwareID int,
--FOREIGN KEY (HardwareID) REFERENCES Hardware(HardwareID),
--RepairID int,
--FOREIGN KEY (RepairID) REFERENCES Repair(RepairID)
--);


--CREATE TABLE AppointmentRepair (
--AppointmentID int,
--FOREIGN KEY (AppointmentID) REFERENCES Appointment(AppointmentID),
--RepairID int,
--FOREIGN KEY (RepairID) REFERENCES Repair(RepairID)
--);

--USE Terminerstellung
--GO 

--INSERT INTO Staff(LastName, FirstName, Wage, Hours, Supervisor)
--VALUES 
--('Klein', 'Thorsten', 12, 1.7, 1),
--('Kurz', 'Sabine', 12, 0.6, 0),
--('Groﬂ', 'Max', 12, 1.1, 0),
--('Lang', 'Lilly', 12, 2.8, 0);

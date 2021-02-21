--Verbesserte Query

--IF DB_ID(N'Terminerstellung') IS NULL
--  CREATE DATABASE Terminerstellung;
--GO

--USE Terminerstellung
--GO

--IF OBJECT_ID('AppointmentRepair') IS NOT NULL
--  DROP TABLE AppointmentRepair;
--GO

--IF OBJECT_ID('AppointmentStaff') IS NOT NULL
--  DROP TABLE AppointmentStaff;
--GO

--IF OBJECT_ID('HardwareRepair') IS NOT NULL
--  DROP TABLE HardwareRepair;
--GO

--IF OBJECT_ID('Appointment') IS NOT NULL
--  DROP TABLE Appointment;
--GO

--IF OBJECT_ID('Bike') IS NOT NULL
--  DROP TABLE Bike;
--GO

--IF OBJECT_ID('Customer') IS NOT NULL
--  DROP TABLE Customer;
--GO

--IF OBJECT_ID('Hardware') IS NOT NULL
--  DROP TABLE Hardware;
--GO

--IF OBJECT_ID('Repair') IS NOT NULL
--  DROP TABLE Repair;
--GO

--IF OBJECT_ID('Staff') IS NOT NULL
--  DROP TABLE Staff;
--GO

--IF OBJECT_ID('Workshop') IS NOT NULL
--  DROP TABLE Workshop;
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
--Straße varchar(100) NOT NULL,
--Hausnummer varchar(100) NOT NULL
--);


--Create Table Workshop (
--WorkshopID int IDENTITY PRIMARY KEY,
--Name varchar(100),
--Postleitzahl INT NOT NULL,
--Ort varchar(100) NOT NULL,
--Straße varchar(100) NOT NULL,
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


--INSERT INTO Staff(LastName, FirstName, Wage, Hours, Supervisor)
--VALUES 
--('Klein', 'Thorsten', 12, 1.7, 1),
--('Kurz', 'Sabine', 12, 0.6, 0),
--('Groß', 'Max', 12, 1.1, 0),
--('Lang', 'Lilly', 12, 2.8, 0);

--Insert into Customer(LastName, FirstName, Postleitzahl, Ort, Straße, Hausnummer)
--Values ('Doe', 'John', 66600, 'Nowhere', 'Elmstreet','12a'),
--	   ('Smith', 'Jane', 00001, 'Castle Rock', 'Main Street','11111'),
--	   ('Picard', 'Jean-Luc', 70190, 'La Barre', 'Grande Rue','3'),
--       ('Scully', 'Dana', 20906, 'Bethesda', '3170 West 53 Rd','35'); 

--Insert into Workshop(Name, Postleitzahl, Ort, Straße, Hausnummer)
--Values ('MorePower', 66130, 'Saarbrücken', 'Kurt-Schumacher-Straße','20');

--Insert into Appointment(Date, Length, AppointmentPrice, CustomerID, WorkshopID)
--Values ('2020-02-11', '2', 50, 2, 1),
--	   ('2020-08-11', '2.5', 62.5, 1, 1),
--	   ('2020-02-12', '3', 75, 3, 1),
--       ('2020-22-11', '2', 50, 4, 1),
--	   ('2020-02-12 10:15:11.000', '2', 50, 2, 1);

--insert into Hardware(HardwareName,HardwarePrice) values ('Scheibenbremse', 100.00);
--insert into Repair(RepairDetails,RepairPrice) values ('Kette reinigen', 30.00);
--insert into Bike(SerialNumber) values(123456);
--insert into HardwareRepair(HardwareID) values (1);

--insert into AppointmentStaff(AppointmentID, StaffID) values(1,1);
--insert into AppointmentRepair(AppointmentID, RepairID) values(1,1);

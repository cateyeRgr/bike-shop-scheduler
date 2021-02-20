use Terminerstellung
go

--Insert into Workshop(Name, Postleitzahl, Ort, Straße, Hausnummer)
--Values ('MorePower', 66130, 'Saarbrücken', 'Kurt-Schumacher-Straße','20');

Insert into Appointment(Date, Length, AppointmentPrice, CustomerID, WorkshopID)
Values ('2020-02-11', '2', 50, 2, 1),
	   ('2020-08-11', '2.5', 62.5, 1, 1),
	   ('2020-02-12', '3', 75, 3, 1),
       ('2020-22-11', '2', 50, 4, 1),
	   ('2020-02-12 10:15:11.000', '2', 50, 2, 1);
insert into Bike(SerialNumber) values(123456);
insert into Hardware(HardwareName,HardwarePrice) values ("Scheibenbremse", 100.00);
insert into Repair(RepairDetails,RepairPrice) values ("Kette reinigen", 30.00);
insert into HardwareRepair(HardwareID) values (1);

insert into AppointmentStaff(AppointmentID, StaffID) values(1,1);
insert into AppointmentRepair(AppointmentID, RepairID) values(1,1);
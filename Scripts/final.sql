
use master
go

create database R33Pharmacy
go

use R33Pharmacy
go


create TABLE [dbo].[Human_Resource_Management]
(

	Status varchar(30) not null,
	Employee_Name varchar(30) not null,
	Address varchar(30) not null,
	[Contact_Number] varchar(30) NOT NULL PRIMARY KEY,
	Salary int not null
)
use R33Pharmacy
go

insert into Human_Resource_Management(Status,Employee_Name,Address,Contact_Number,Salary) values('Manager','Shakil','Ctg','1234',10000),
																							('Accountant','Arafat','Dhaka','1235',9000),
																							('Assistent','Naslo','Ctg','1236',8000)

CREATE TABLE [dbo].[Sales_Details]
(
	Company_name varchar(30) not null,
	Group_Name varchar(30) not null,
	Medicine_Name varchar(30) not null,
	[Medicine_Id] INT NOT NULL PRIMARY KEY identity(400,1),
	Quantity int not null,
	Price_per_box decimal not null,
	Total_Sails as Quantity*Price_per_box
)
use R33Pharmacy
go

Insert into [dbo].[Sales_Details](Company_name ,Group_Name,Medicine_Name,Quantity,Price_per_box) values('Square','Omeprazol','Seclo',10,12),
																									('Incepta','Omeprazol','Inprazol',11,13),
																									('ACI','Omeprazol','Ciprazol',12,13),
																									('Square','paracetamol','Napha',9,8),
																									('Incepta','paracetamol','Parapirol',10,16),
																									('ACI','paracetamol','Acitamol',10,13),
																									('Square','Acitamenophen','Alatrol',20,3),
																									('Incepta','Omeprazol','Omenix',11,13)
																									

CREATE TABLE [dbo].[Accounts]
(
	[Id] INT NOT NULL PRIMARY KEY identity(100,1),
	[Contact_Number] varchar(30) NOT NULL foreign KEY references Human_Resource_Management(Contact_Number),
	[Medicine_Id] INT NOT NULL foreign KEY references Sales_Details(Medicine_Id)
)

INSERT INTO Accounts values('1234',400),('1235',401),('1236',402)

CREATE TABLE [dbo].[Stock_Details]
(
	Company_name varchar(30) not null,
	Group_Name varchar(30) not null,
	Medicine_Name varchar(30) not null,
	[Medicine_Id] INT NOT NULL foreign KEY references Sales_Details(Medicine_Id),
	Quantity int not null
	
)
	
use R33Pharmacy
go

Insert into [dbo].[Stock_Details](Company_name ,Group_Name,Medicine_Name,Medicine_Id,Quantity) values('Square','Omeprazol','Seclo',400,12),
																									('Incepta','Omeprazol','Inprazol',401,13),
																									('ACI','Omeprazol','Ciprazol',402,13),
																									('Square','paracetamol','Napha',403,8),
																									('Incepta','paracetamol','Parapirol',404,16),
																									('ACI','paracetamol','Acitamol',405,13),
																									('Square','Acitamenophen','Alatrol',406,3)




use R33Pharmacy
go


create view vw_Accounts       
as
select s.Medicine_Name,s.Total_Sails,h.Employee_Name,h.Salary
from Sales_Details s
join Accounts a
on s.Medicine_Id=a.Medicine_Id 
join Human_Resource_Management h
on a.Contact_Number =h.Contact_Number
go																									

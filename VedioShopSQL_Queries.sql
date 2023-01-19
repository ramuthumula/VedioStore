use WI_Training_RamuT

Create table Tapes(TapeId integer primary key,Title Varchar(50),Cost Real,RentalPrice Real,QuantityAvailable Integer, QuantityRented integer)

go

create table Customers(CustId integer primary key,CustName varchar(60),CustAddress varchar(100),City varchar(40),state varchar(2),Zip char(9) check (len(Zip)=5 or len(Zip)=9),Phone varchar(15) check (len(Phone)=10),MemberSince date)

go 

create table Rentals(TapeId integer foreign key REFERENCES Tapes(TapeId),
CustId integer foreign key references Customers(CustId),
RentedDate date,
DueBack date,
constraint checkdate check(DueBack>=RentedDate))

go



CREATE PROCEDURE GetAllRentals
AS
BEGIN
SET NOCOUNT ON
 
select T2.TapeId,T2.CustId,T2.CustName,T1.Title 
	from Tapes T1 inner join 
	(select Rentals.TapeID,Rentals.CustId,Customers.CustName 
		from Rentals inner join 
			Customers on Rentals.CustId=Customers.CustId)
	T2 on T1.TapeId=T2.TapeId
END



CREATE PROCEDURE GetNamedRentals
(@Name varchar(50))
AS
BEGIN
SET NOCOUNT ON
select * from  
(select T2.TapeId,T2.CustId,T2.CustName,T1.Title 
	from Tapes T1 inner join 
	(select Rentals.TapeID,Rentals.CustId,Customers.CustName 
		from Rentals inner join 
			Customers on Rentals.CustId=Customers.CustId)
	T2 on T1.TapeId=T2.TapeId) T2
	where T2.CustName=@Name
END




CREATE PROCEDURE GetCustomers
AS
BEGIN
SET NOCOUNT ON
select distinct CustName from Customers
END



CREATE PROCEDURE CheckAvailability
(@TapeId integer)
AS
BEGIN
SET NOCOUNT ON
select  QuantityAvailable from Tapes where TapeId=@TapeId
End



CREATE PROCEDURE BuyTape
(@TapeId integer,@CustId integer,@RentalDate date,@DueDate date)
AS
BEGIN
SET NOCOUNT ON
update Tapes set QuantityAvailable=QuantityAvailable-1 where TapeId=@TapeId
update Tapes set QuantityRented=QuantityRented+1 where TapeId=@TapeId
insert into Rentals values(@TapeId,@CustId,@RentalDate,@DueDate)
End


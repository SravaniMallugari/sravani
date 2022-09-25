create database Librarysystem
use Librarysystem

create table Member
(
Member_ID int,
Member_Name varchar(25),
Acc_Open_Date Date,
Max_Books_Allowed int,
Penalty_Amount int
)
create table Book
(
Book_No int,
Book_Name varchar(30),
Author char(30),
Cost Numeric(7,2),
Category char(10)
)
create  table Issue 
(
Lib_Issue_Id numeric(10),
Book_No numeric(6),
Member_Id numeric(5),
Issue_Date date,
Return_Date date
)
--3rd qstn
alter table Issue
add comments Varchar(100)
--4th
alter table Member
alter column Member_Name varchar(30) 
--5th
alter table Issue
add Reference Varchar(30)
--6th
alter table Issue
drop  column Reference
--7th
go
 sp_rename Issue,Lib_Isssue


--8TH
go
insert into Member Values(1,'Richa Sharma','2005-12-10',5,50)
insert into Member Values(2,'Garima Sen',current_Timestamp,3,Null)
insert into Member values (3,'isra','20-feb-2020'	,3,	45)
insert into Member values (4,'shylu','14-nov-2017'	,Null,	Null)
insert into Member values (5,'siddarath','1-june-2010'	,33,	70)
insert into Member values (6,'ram',SYSDATETIME()	,30,	800)
go
select * from Member
go
DELETE FROM Member WHERE Member_Id=3
--9
go
ALTER TABLE Member
  ALTER COLUMN Member_Name CHAR(20) 
 --10
go
insert into Member values (7,'maggi',SYSDATETIME()	,110,	170)
--Msg 8115, Level 16, State 8, Line 62 Arithmetic overflow error converting int to data type numeric. The statement has been terminated.
--11
go
create table Member101
(
Member_Id	NUMERIC(5) 	,
Member_Name	Char(25),	 
Acc_Open_Date	Date	,
Max_Books_Allowed	NUMERIC(2),
Penalty_Amount	NUMERIC(7,2)
)
--12
go

insert into Book values (101,'Let us C'	,'Denis Ritchie',450,'System')
insert into Book values (102	,'Oracle – Complete Ref'	,'Loni'	,550	,'Database')
insert into Book values (103	,'Mastering SQL'	,'Loni',	250	,'Database') 
insert into Book values (104,	'PL SQL-Ref',	'Scott Urman'	,750	,'Database')
go
select * from Book

select * into Book101 from Book
select * from Book101

select * from Member
select * from Book

insert into Book values(105,'National Geographic','Adis Scott',1000,'Science')

delete from Book 
where Book_No =105
update Book set cost = 300,category = 'RDBMS' where Book_No = 103 

insert into Lib_Isssue(Lib_Issue_Id,book_no,member_id,issue_date) values(7001,101,1,'10-Dec-06')

insert into  Lib_Isssue(Lib_Issue_Id,book_no,member_id,issue_date) values(7002,102,2,'25-Dec-06')

insert into  Lib_Isssue(Lib_Issue_Id,book_no,member_id,issue_date) values(7003,104,1,'15-Jan-06')

insert into  Lib_Isssue(Lib_Issue_Id,book_no,member_id,issue_date) values(7004,101,1,'04-Jul-06')

insert into  Lib_Isssue(Lib_Issue_Id,book_no,member_id,issue_date) values(7005,104,2,'15-Nov-06')

insert into  Lib_Isssue(Lib_Issue_Id,book_no,member_id,issue_date) values(7006,101,3,'18-Feb-06')


select * from Lib_Isssue


select * from issue

update member set penalty_amount = 100 where member_id = 2

select * from member

delete from Lib_Isssue
where member_id = 1 and issue_date < '10-Dec-06'

select * from Lib_Isssue


delete from Book
where category != 'RDBMS' and category != 'Database'
select * from Book






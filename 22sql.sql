use Librarysystem
Select Category,avg(Cost) as average from Book group by Category having Category='Database'
Select Category,count(distinct(Book_No)) as NumberofBooks from Book group by Category
Select Book_No,count(Book_No) as count1 from Lib_Isssue group by Book_No order by count1 desc
Select max(Penalty_Amount) as max,min(Penalty_Amount) as min,sum(Penalty_Amount) as total,avg(Penalty_Amount) as average from member
Select Member_ID,count(distinct(Book_No)) as booksborrowed from Lib_Isssue group by Member_Id having count(distinct(Book_No))>=2
Select member_id,Book_No,count(distinct(Book_No)) as count1 from Lib_Isssue group by Book_No,Member_Id order by count1 desc--needs to check
Select datename(MONTH,Issue_Date) as monthnames,COUNT(Book_No) as noofbooks from Lib_Isssue group by datename(Month,Issue_Date) order by 2 desc 
Select * from Lib_Isssue
Select Book_No,Book_Name from Book where Book_No not in(Select Book_No from Lib_Isssue)
Select i.member_id from Lib_Isssue i inner join member j on i.Member_Id=j.member_id group by i.member_id having count(Book_No)>0 --question8
Select member_id from Lib_Isssue where member_id in(Select member_id from member) intersect (Select member_id from Lib_Isssue group by member_id having count(Book_No)>0)--qn8
Select top 1 member_id,count(Book_No) as count1 from Lib_Isssue group by member_id order by count1 desc 
Select top 1 member_id,count(Book_No) as count1 from Lib_Isssue group by member_id order by count1
Select * from Lib_Isssue where DATENAME(month,Issue_Date) in ('July','December')
Select i.Book_No,i.Book_Name,j.Issue_Date FROM Book i inner join Lib_Isssue j on i.Book_No=j.Book_No where MONTH(j.Issue_date)=12 and i.Category='Database' Select Lib_Isssue.member_id,member.member_name,count(Lib_Isssue.Book_No) as count1  from member inner join Lib_Isssue on Lib_Isssue.Member_Id=member.Member_Id group by Lib_Isssue.member_id,member.member_name order by count1 desc
Select Lib_Isssue.Lib_Issue_Id,Lib_Isssue.Member_Id,Lib_Isssue.Book_No,Lib_Isssue.Issue_Date,Lib_Isssue.Return_date from Lib_Isssue inner join member on Lib_Isssue.Member_Id=member.member_id where member.member_name='Richa Sharma'
Select * from member where member_id in (Select Lib_Isssue.member_id from Lib_Isssue inner join Book on Lib_Isssue.Book_No=Book.Book_No where Book.Category='Database') 
Select Category,max(Cost) as highprice from Book group by Category
Select Lib_Isssue.Lib_Issue_Id,Lib_Isssue.Member_Id,Lib_Isssue.Book_No from Lib_Isssue inner join member on Lib_Isssue.Member_Id=member.member_id where Lib_Isssue.Issue_Date not between member.Acc_open_date and Lib_Isssue.Return_date
Select * from member
Select * from member where member_id not in(Select member.member_id from Lib_Isssue inner join member on member.member_id=Lib_Isssue.Member_Id group by member.member_id)
Select member.member_id,member.member_name,count(Lib_Isssue.Book_No) as booksissued,member.Max_Books_Allowed  from Lib_Isssue inner join member on Lib_Isssue.Member_Id=member.member_id  group by member.member_id,member.member_name,member.Max_Books_Allowed having member.Max_Books_Allowed<=count(Lib_Isssue.Book_No)
Select member.member_id,member_name,Lib_Isssue.Book_No from Lib_Isssue inner join member on member.member_id=Lib_Isssue.Member_Id where Lib_Isssue.Book_No in(Select Lib_Isssue.Book_No from Lib_Isssue inner join member on member.member_id=Lib_Isssue.Member_Id where member.member_name like'Garima%')
Select Book.Book_No,Book.Book_Name,Book.Cost from Lib_Isssue inner join Book on Lib_Isssue.Book_No=Book.Book_No where DATEDIFF(day,Lib_Isssue.Issue_Date,Lib_Isssue.Return_date)>30 
Select Book_Name,author from Book where author in (Select author from book group by author having count(Book_Name)>1)
Select top 3 * from Book order by Cost desc
Select sum(Cost) from Book where Book_No in(Select Book_No from Lib_Isssue where Return_date is null)
Select * from Book where Book_No in(Select top 1 Book_No from Lib_Isssue group by Book_No order by count(Book_No) desc)
create database Employeemanagement1
use Employeemanagement1

create table Employee_Details (
    Emp_No int primary key,
    Emp_Name varchar(50) NOT NULL,
    Emp_Sal float check (Emp_Sal >= 25000),
    Emp_Type varchar(1) check (Emp_Type IN ('P', 'C'))
);





-- Create the stored procedure to insert multiple rows

create procedure Employeee_Details
    @Emp_Name varchar(50),
    @Emp_Sal float,
    @Emp_Type varchar(1)
as
begin
    declare @gen_Empno int;
    select @gen_Empno = isnull(MAX(Emp_No), 10) + 1 from Employee_Details;
    insert into Employee_Details (Emp_No, Emp_Name, Emp_Sal, Emp_Type)
    values (@gen_Empno, @Emp_Name, @Emp_Sal, @Emp_Type);
    select @gen_Empno as Emp_No; 
end;

exec Employeee_Details'Riya', 1000, 'P';
select*from Employee_Details


use Assessments
use AssignmentDB

/*--------question1------------------------*/
create table BIRTH (
    Person_name varchar(20),
    Birth_Date datetime,
    AGE int
);

insert into BIRTH values
    ('Riya', '2001-06-12', 21),
    ('Priya', '2002-09-20', 16),
    ('Diya', '2003-03-20', 32);

-- query to display your birthday( day of week)
select Person_name, Birth_Date, DATENAME(dw, Birth_Date) as 'Day Of Week' from BIRTH;

Person_name    Birth_Date              Day Of Week
Riya	    2001-06-12 00:00:00.000  	Tuesday
Priya	    2002-09-20 00:00:00.000	    Friday
Diya	    2003-03-20 00:00:00.000	    Thursday


/*-------------------question2-----------------------------------------------------------------------------------------*/
--query to display your age in days 
select Person_name, Birth_Date, AGE, DATEDIFF(day,Birth_Date,getdate()) as Days from BIRTH;

Person_name  Birth_Date                AGE DAYS
Riya	     2001-06-12 00:00:00.000	21	8325
Priya	     2002-09-20 00:00:00.000	16	7860
Diya	     2003-03-20 00:00:00.000	32	7679





/*---------------question 3-----------------------------------------------------------------------------------------------------*/
create table EMP1 (
    EMPNO Numeric(4) Primary Key,
    ENAME Varchar(10),
    JOB Varchar(10),
    MGR_ID Numeric(4),
    HIREDATE DATE,
    SAL Numeric(4),
    COMM Numeric(4),
    DEPTNO Numeric(4) Foreign Key references DEPT(DEPTNO)
)

Insert Into EMP1 Values(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
					  (7499, 'ALLEN', 'SALESMAN', 7698, '2023-03-23', 1600, 300, 30),
					  (7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
					  (7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
					  (7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
					  (7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
					  (7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
					  (7788, 'SCOTT', 'ANALYST', 7566, '2023-03-03', 3000, NULL, 20),
					  (7839, 'KING', 'PRESIDENT', NULL, '2023-03-19', 5000, NULL, 10),
					  (7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
					  (7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
					  (7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
					  (7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
					  (7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10)
select * from EMP1
update EMP1
SET HIREDATE = '2019-03-03'
WHERE EMPNO = 7369;
update EMP1
SET HIREDATE = '2019-03-23'
WHERE EMPNO = 7902;

select * from EMP1
where hiredate <= Dateadd(year, -5, Getdate())
and Month(hiredate) = Month(Getdate())

EMPNO  ENAME     JOB   MGR_ID   HIREDATE    SAL  COMM   DEPTNO
7369	SMITH	CLERK	7902	2019-03-03	800	  NULL	20
7902	FORD	ANALYST	7566	2019-03-23	3000  NULL	20











/*--------------question 4------------------------*/
BEGIN TRANSACTION;

-- Create table Employee
create table Employee (
    Empno INT PRIMARY KEY,
    Ename VARCHAR(50),
    Sal DECIMAL(10, 2),
    Doj DATE
);

-- a. Insert 3 rows
insert into Employee values(1, 'Riya', 50000, '2022-01-01'),
						   (2, 'Priya', 60000, '2022-01-02'),
						   (3, 'Diya', 55000, '2022-01-03')
select * from Employee
1	Riya	50000.00	2022-01-01
2	Priya	60000.00	2022-01-02
3	Diya	55000.00	2022-01-03

-- b. Update the second row sal with 15% increment
update Employee set Sal = Sal * 1.15 WHERE Empno = 2

1	Riya	50000.00	2022-01-01
2	Priya	60000.00	2022-01-02
3	Diya	55000.00	2022-01-03

-- c. Delete first row
DELETE FROM Employee WHERE Empno = 1
2	Priya	69000.00	2022-01-02
3	Diya	55000.00	2022-01-03
COMMIT;

-- Recall the deleted row
SELECT * FROM DeletedEmployee;

/*-----------------question5----------------*/
create function Calculate_Bonus (@deptno int, @sal decimal(10, 2))
returns decimal(10, 2)
as
begin
    declare @bonus decimal(10, 2);

    if @deptno = 10
        set @bonus = @sal * 0.15;

    else if @deptno = 20
        set @bonus = @sal * 0.20;
    else
        set @bonus = @sal * 0.05;

    return @bonus;
end;
go

-- Example usage of the user-defined function
select Empno, Ename, Salary, Deptno, dbo.Calculate_Bonus(Deptno, Salary) AS bonus from Employees
Empno   Ename  Salary Deptno  bonus
7001	Sandeep	25000	10	3750.00
7002	Rajesh	30000	10	4500.00
7003	Madhav	40000	20	8000.00
7004	Manoj	40000	20	8000.00
7005	Abhay	35000	10	5250.00
7006	Uma	    30000	30	1500.00
7007	Gita	30000	40	1500.00
7008	Priya	35000	30	1750.00
7009	Nutan	45000	20	9000.00
7010	Smita	20000	10	3000.00
7011	Anand	65000	10	9750.00

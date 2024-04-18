use AssignmentDB


select* from EMP
select* from DEPT

/*Query 1---------------------------------------*/
select ENAME as 'List of Managers' from EMP where JOB='Manager'

/*Query 2---------------------------------------*/
select ENAME as 'Employee Names', SAL as 'Salary per month' from EMP where SAL>1000

/*Query 3---------------------------------------*/
select ENAME as 'Employee Names', SAL as Salary from EMP where ENAME != 'James'

/*Query 4---------------------------------------*/
select ENAME from EMP where ENAME like 'S%'

/*Query 5---------------------------------------*/
select ENAME from EMP where ENAME like '%A%'

/*Query 6---------------------------------------*/
select ENAME from EMP where ENAME like '__L%'

/*Query 7---------------------------------------*/
select ENAME,SAL,SAL/30 as 'Daily Salary' from EMP where ENAME='JONES'

/*Query 8---------------------------------------*/
select sum(SAL) as 'Total Salary of all Employees' from EMP

/*Query 9---------------------------------------*/
select sum(SAL) as 'Total Salary of all Employees', avg(SAL) as 'Average Salary of all Employees' from EMP
 
/*Query 10---------------------------------------*/
select ENAME, JOB, SAL, DEPTNO FROM EMP where JOB !='SALESMAN'

/*Query 11---------------------------------------*/
select distinct e.deptno, d.dname
from EMP e
join DEPT d on e.deptno = d.deptno

/*Query 12---------------------------------------*/
select ENAME as Employee, SAL as 'Monthly Salary' from EMP where SAL>1500 and DEPTNO in(10,30)

/*Query 13---------------------------------------*/
select ENAME, JOB, SAL from EMP
where(JOB = 'MANAGER' or JOB = 'ANALYST') and SAL NOT IN (1000,3000,5000)

/*Query 14---------------------------------------*/
select ENAME as Name, SAL AS Salary, COMM AS Commission
from EMP
where COMM > SAL * 1.1;

/*Query 15---------------------------------------*/ 
select ENAME as Name
from EMP
where (ENAME LIKE '%L%L%' AND DEPTNO = 30) OR MGR_ID = 7782

/*Query 16---------------------------------------*/ 
select ENAME, DATEDIFF(YEAR, HIREDATE, GETDATE()) as YearsOfExperience from EMP
where DATEDIFF(YEAR, HIREDATE, GETDATE()) BETWEEN 30 AND 39;
select COUNT(*) as TotalEmployees
from EMP

/*Query 17---------------------------------------*/ 
select
D.DNAME as DepartmentName,
E.ENAME as EmployeeName
from 
DEPT D
INNER JOIN 
EMP E ON D.DEPTNO = E.DEPTNO
where
E.DEPTNO IS NOT NULL
ORDER BY 
D.DNAME ASC,
E.ENAME DESC;

/*Query 18---------------------------------------*/ 
select
DATEDIFF(YEAR, HIREDATE, GETDATE()) as ExperienceInYears
from EMP where ENAME = 'MILLER';



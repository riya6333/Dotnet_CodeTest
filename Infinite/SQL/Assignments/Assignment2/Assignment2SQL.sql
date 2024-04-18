use AssignmentDB

create table DEPT (
    DEPTNO Numeric(4) Primary Key,
    DNAME VARCHAR(10),
    LOC VARCHAR(10)
)

create table EMP (
    EMPNO Numeric(4) Primary Key,
    ENAME Varchar(10),
    JOB Varchar(10),
    MGR_ID Numeric(4),
    HIREDATE DATE,
    SAL Numeric(4),
    COMM Numeric(4),
    DEPTNO Numeric(4) Foreign Key references DEPT(DEPTNO)
)

Insert into DEPT Values(10, 'ACCOUNTING', 'NEW YORK'),
					   (20, 'RESEARCH', 'DALLAS'),
					   (30, 'SALES', 'CHICAGO'),
					   (40, 'OPERATIONS', 'BOSTON')

Insert Into EMP Values(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
					  (7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
					  (7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
					  (7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
					  (7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
					  (7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
					  (7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
					  (7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
					  (7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
					  (7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
					  (7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
					  (7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
					  (7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
					  (7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10)

select* from EMP
select* from DEPT

/*1Query----------------------------*/
select* from EMP where ENAME like 'A%'

/*2Query----------------------------*/
select* from EMP where MGR_ID IS Null

/*3Query----------------------------*/
select ENAME, EMPNO,SAL from EMP where SAL Between 1200 and 1400

/*4Query----------------------------*/
-- Before pay rise
select* from EMP where DEPTNO = 20

-- Applying the pay rise
update EMP
SET SAL = SAL * 1.1 
where DEPTNO = 20

-- After pay rise
select* from EMP
where DEPTNO = 20

/*5Query----------------------------*/
select COUNT(*) AS "Number of Clerks" from EMP
where JOB = 'CLERK'

/*6Query----------------------------*/
select JOB, AVG(SAL) AS "Average Salary", COUNT(*) AS "Number of Employees" 
from EMP 
GROUP BY JOB

/*7Query----------------------------*/
select* from EMP
where SAL IN (select MIN(SAL) from EMP)
OR SAL IN (select MAX(SAL) from EMP)

/*8Query----------------------------*/
select* from DEPT
where DEPTNO NOT IN (select DISTINCT DEPTNO from EMP)

/*9Query----------------------------*/
select ENAME, SAL from EMP
where JOB = 'ANALYST' AND SAL > 1200 AND DEPTNO = 20
ORDER BY ENAME 

/*10Query----------------------------*/
select D.DNAME, D.DEPTNO, SUM(E.SAL) AS "Total Salary"
from DEPT D
LEFT JOIN EMP E ON D.DEPTNO = E.DEPTNO
GROUP BY D.DNAME, D.DEPTNO;

/*11Query----------------------------*/
select ENAME, SAL from EMP
where ENAME IN ('MILLER', 'SMITH')

/*12Query----------------------------*/
select ENAME from EMP
where ENAME LIKE 'A%' OR ENAME LIKE 'M%'

/*13Query----------------------------*/
select ENAME, SAL * 12 AS "Yearly Salary" from EMP
where ENAME = 'SMITH'

/*14Query----------------------------*/
select ENAME, SAL from EMP
where SAL NOT BETWEEN 1500 AND 2850;

/*15Query----------------------------*/
select M.ENAME AS "Manager Name", COUNT(E.EMPNO) AS "Number of Employees"
from EMP M
JOIN EMP E ON M.EMPNO = E.MGR_ID
where M.JOB = 'MANAGER'
GROUP BY M.ENAME
HAVING COUNT(E.EMPNO) > 2;



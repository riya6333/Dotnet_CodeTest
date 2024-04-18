create database Assessments
use Assessments

create table books (
    id NUMERIC(2) PRIMARY KEY,
    title VARCHAR(20) NOT NULL,
    author VARCHAR(20) NOT NULL,
    isbn NUMERIC(20) UNIQUE NOT NULL,
    published_date  Datetime NOT NULL
);

create table reviews (
    id NUMERIC(2) PRIMARY KEY ,
    book_id NUMERIC(2) foreign key references books(id),
    reviewer_name VARCHAR(10) NOT NULL,
	content VARCHAR(10),
    rating NUMERIC(2) NOT NULL,
    published_date  Datetime NOT NULL
);


insert into books (id, title, author, isbn, published_date) values
(1, 'My First SQL book', 'Mary Parker', 981483029127, '2012-02-22 12:08:17'),
(2,'My Second SQL book', 'Jojn Mayer', 857300923713, '1972-07-03 09:22:45'),
(3, 'My Third SQL book', 'Cary Flint', 523120967812, '2015-10-18 14:05:44')

insert into reviews(id, book_id, reviewer_name, content, rating, published_date) values
(1, 1, 'John Smith','My First Review', 4,'2017-12-10 05:50:11'),
(2, 2, 'John Smith','My Second Review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker','Another Review', 1, '2017-10-22 23:47:10')

select * from books
/*1---------------------------------------*/
select id, title, author, isbn, published_date from books where author like '%er'

/*2---------------------------------------*/






create database Assessments
use Assessments

create table books (
    id NUMERIC(2) PRIMARY KEY,
    title VARCHAR(30) NOT NULL,
    author VARCHAR(30) NOT NULL,
    isbn NUMERIC(20) UNIQUE NOT NULL,
    published_date  Datetime NOT NULL
);

create table reviews (
    id NUMERIC(2) PRIMARY KEY ,
    book_id NUMERIC(2) foreign key references books(id),
    reviewer_name VARCHAR(15) NOT NULL,
	content VARCHAR(30),
    rating NUMERIC(2) NOT NULL,
    published_date  Datetime NOT NULL
);

create table CUSTOMERS (Cust_id int primary key,
						Name varchar(30),
						Age NUMERIC(2),
						Address varchar(30),
						Salary decimal(10, 2))

create table ORDERS (OID int primary key,
					Order_Date Datetime,
					Customer_ID INT foreign key references CUSTOMERS(Cust_id),
					Amount DECIMAL(10, 2))

create table Employee(Empid int primary key,
					   Ename varchar(30),
					   EAge int, address varchar(30),
					   Emp_Salary decimal(10, 2))

create table StudentDetails(SNO int,
							Reg_No int primary key,
							Student_Name varchar(30), StudentAge int,
							Qualification varchar(30), 
							MobileNo varchar(15), Mail_id varchar(40),
							StuLocation varchar(30),
							Gender char(1))


insert into books (id, title, author, isbn, published_date) values
(1, 'My First SQL book', 'Mary Parker', 981483029127, '2012-02-22 12:08:17'),
(2,'My Second SQL book', 'John Mayer', 857300923713, '1972-07-03 09:22:45'),
(3, 'My Third SQL book', 'Cary Flint', 523120967812, '2015-10-18 14:05:44')

insert into reviews(id, book_id, reviewer_name, content, rating, published_date) values
(1, 1, 'John Smith','My First Review', 4,'2017-12-10 05:50:11'),
(2, 2, 'John Smith','My Second Review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker','Another Review', 1, '2017-10-22 23:47:10')

insert into CUSTOMERS values(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
							(2, 'Khilan', 25, 'Delhi', 1500.00),
							(3, 'Kaushik', 23, 'Kota', 2000.00),
							(4, 'Chaitali', 25, 'Mumbai', 6500.00),
							(5, 'Hardik', 27, 'Bhopal', 8500.00),
							(6, 'Komal', 22, 'MP', 4500.00),
							(7, 'Muffy', 24, 'Indore', 10000.00)

insert into ORDERS values(102, '2009-10-08 00:00:00', 3, 3000),
						 (100, '2009-10-08 00:00:00', 3, 1500),
						 (101, '2009-11-20 00:00:00', 2, 1560),
						 (103, '2008-05-20 00:00:00', 4, 2060);


create table Employeee(Emp_id int primary key, 
					   Empname varchar(30),
					   EmpAge int, address varchar(30),
                       Emp_Salary decimal(10, 2))
					   
 
insert into Employeee values(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
						   (2, 'Khilan', 25, 'Delhi', 1500.00),
						   (3, 'Kaushik', 23, 'Kota', 2000.00),
						   (4, 'Chaitali', 25, 'Mumbai', 6500.00),
						   (5, 'Hardik', 27, 'Bhopal', 8500.00),
						   (6, 'Komal', 22, 'MP', null),
						   (7, 'Muffy', 24, 'Indore', null)

insert into StudentDetails values (1, 2, 'sai', 22, 'B.E', '9952836777', 'sai@gmail.com', 'Chennai', 'M'),
								  (2, 3, 'kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
								  (3, 4, 'selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
								  (4, 5, 'nisha', 25, 'M.E', '7834672310', 'nisha@gmail.com', 'Theni', 'F'),
								  (5, 6, 'saisaran', 21, 'BA', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
								  (6, 7, 'tom', 23, 'BCA', '8901234675', 'tom@gmail.com', 'Pune', 'M');

select * from books
select * from reviews
/*1---------------------------------------*/
select id, title, author, isbn, published_date from books where author like '%er'

/*2---------------------------------------*/
SELECT b.title, b.author, r.reviewer_name
FROM books b
INNER JOIN reviews r ON b.id = r.book_id;

/*3---------------------------------------*/
select reviewer_name
from reviews
GROUP BY reviewer_name
HAVING COUNT(DISTINCT book_id) > 1;

/*4---------------------------------------*/
select Name 
from CUSTOMERS
where Address LIKE '%o%';

/*5---------------------------------------*/
select Order_Date AS Date,COUNT ( Customer_ID)
from ORDERS 
GROUP BY Order_Date;

/*6---------------------------------------*/
SELECT LOWER(Empname) AS Lowercase_Name
FROM Employeee
WHERE Emp_Salary IS NULL

/*7---------------------------------------*/
SELECT Gender, COUNT(*) AS Total_Count
FROM StudentDetails
GROUP BY Gender;


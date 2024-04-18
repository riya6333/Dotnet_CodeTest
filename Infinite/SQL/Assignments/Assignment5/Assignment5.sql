use AssignmentDB
 select * from EMP
create procedure Payslip 
@EMPNO int
as
begin
    declare @Salary decimal(10, 2)
    declare @HRA decimal(10, 2)
    declare @DA decimal(10, 2)
    declare @PF decimal(10, 2)
    declare @IT decimal(10, 2)
    declare @GrossSalary decimal(10, 2)
    declare @Deductions decimal(10, 2)
    declare @NetSalary decimal(10, 2)
	declare @EmpName varchar(30)

   -- Get Employee's Salary
   select @Salary = SAL,
   @EmpName = ENAME
   from EMP
   where  EMPNO =  @EMPNO

	if @Salary is not null
	begin

    -- Calculate HRA, DA, PF, and IT
    set @HRA = 0.1 * @Salary
    set @DA = 0.2 * @Salary
    set @PF = 0.08 * @Salary
    set @IT = 0.05 * @Salary

    -- Calculate Gross Salary
    set @GrossSalary = @Salary + @HRA + @DA

    -- Calculate Deductions
    set @Deductions = @PF + @IT

    -- Calculate Net Salary
    set @NetSalary = @GrossSalary - @Deductions

    -- Display Payslip
    select 
            @EMPNO as EMPID,
            @EmpName as 'Employee Name',
            @salary as 'Basic Salary',
            @HRA as HRA,
            @DA as DA,
            @PF as PF,
            @IT as IT,
            @deductions as Deductions,
            @grosssalary as 'Gross Salary',
            @netsalary as 'Net Salary'
end
else
	begin
		print 'Employee ID do not Found'
	end
end	
EXEC Payslip  @EMPNO = 7369;



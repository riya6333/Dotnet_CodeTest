use AssignmentDB


/* -------------------------------------------T-SQL Program to find the factorial of a given number.-----------------------------------*/
DECLARE @number INT = 4;
DECLARE @factorial INT = 1;
DECLARE @i INT = 1;

WHILE @i <= @number
BEGIN
    SET @factorial = @factorial * @i;
    SET @i = @i + 1;
END

SELECT @factorial AS Factorial;

/*----------------------Create a stored procedure to generate multiplication tables up to a given number---------------------------------*/
CREATE PROCEDURE MultiplicationTables
    @maxNumber INT 
AS
BEGIN
    DECLARE @i INT = 1;
    DECLARE @j INT;

    WHILE @i <= @maxNumber
    BEGIN
        SET @j = 1; 

        WHILE @j <= @maxNumber
        BEGIN
            PRINT CAST(@start AS VARCHAR(10)) + ' * ' + CAST(@end AS VARCHAR(10)) + ' = ' + CAST(@start * @end AS VARCHAR(10));
            SET @j = @j + 1;
        END

        SET @i = @i + 1;
        PRINT '-----------------------';
    END
END;
GO
EXEC MultiplicationTables @maxNumber = 4;



/*--------query 3-----------------------------------------------------------------------------------------------*/
create table Holiday_Table (
    Holiday_Date Date primary key,
    Holiday_Name varchar(30)
);

insert into Holiday_Table values ('2024-01-01', 'New Year Day'),
						         ('2024-01-26', 'Republic Day'),
						         ('2024-08-15', 'Independence Day'),
						         ('2024-10-02', 'Gandhi Jayanti ');


create trigger RestrictedTrigger on EMP
after insert, delete, update
as
begin
    declare @Current_Date date;
    declare @Holiday_Name varchar(30);

    set @Current_Date = getdate();
    select @Holiday_Name = Holiday_Name from Holiday_Table where Holiday_Date = @Current_Date;

    if @Holiday_Name is not null
    begin
        raiserror('Due to %s, you cannot manipulate data.', 16, 1, @Holiday_Name);
        rollback; 
    end
end;

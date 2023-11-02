
/*Stored Procedure*/


/*Create Teacher*/

CREATE PROCEDURE SP_Create_TeacherAcc
	@firstname nvarchar (50),
	@lastname nvarchar (50),
	@email nvarchar(50),
	@Password nvarchar (50)
AS
begin
	Insert into tbl_TeacherAcc(firstname,lastname,email,teacher_password)
	values(@firstname,@lastname,@email,@Password);
end

/*View Teacher Account*/
CREATE PROCEDURE SP_View_TeacherAcc
as
begin
	
	Select * From tbl_TeacherAcc
end





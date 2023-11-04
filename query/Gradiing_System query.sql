/*============ Table ==================*/

Create Table tbl_Admin(
	adminId int identity(10000,1) Primary Key,
	admin_User nvarchar(50),
	admin_Pass nvarchar(50)
)


--TEACHER TABLE
Create Table tbl_TeacherAcc(
	teacherId int identity(23000,1) Primary Key,
	firstName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	email nvarchar(50) Not Null,
	teacher_password nvarchar(50) Not Null,	
);

Create Table tbl_TeacherInfo(
	
	middleName nvarchar(50),
	gender nvarchar(30),
	birthDate Date,
	age int,
	phoneNumber nvarchar(50),
	FK_teacherId int FOREIGN KEY REFERENCES tbl_TeacherAcc(teacherId)
);


--STUDENT TABLE

--GRADE 1
Create Table tbl_Students(
	studentId int identity(604500,1) Primary Key,
	firstName nvarchar(50) Not Null,
	middleName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	age int,
	gender nvarchar(30),
	birthDate date Not Null,
	grade int,
	section nvarchar(30),
	CreatedBy nvarchar(75) not null 
);


--buhatig subject term table

Create table tbl_Student_PrelimSubject(
	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	Mapeh_Prelim float,
	English_Prelim float,
	Math_Prelim float,
	Filipino_Prelim float,
	Science_Prelim float,
	Period_Avg_Prelim float(3),
	Period_Status_Prelim nvarchar(30),
	updatedBy nvarchar(50),
	
)

Create table tbl_Student_MidtermSubject(
	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	Mapeh_Midterm float,
	English_Midterm float,
	Math_Midterm float,
	Filipino_Midterm float,
	Science_Midterm float,
	Period_Avg_Midterm float (3),
	Period_Status_MIdterm nvarchar(30),
	updatedBy nvarchar(50)
	
)

Create table tbl_Student_FinalSubject(
	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	Mapeh_Final float,
	English_Final float,
	Math_Final float,
	Filipino_Final float,
	Science_Final float,
	Period_Avg_Final float(3),
	Period_Status_Final nvarchar(30),
	updatedBy nvarchar(50)
	
)

--STUDENT TERMS TABLE

Create Table tbl_Grading_Period(
	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	prelim_avg float(3),
	midterm_avg float(3),
	final_avg float(3),
	overall float(3),
	
	--status
--	prelim_Status nvarchar(30),
--	midterm_Status nvarchar(30),
--	Final_Status nvarchar(30),
--	Overall_Status nvarchar(30),
);

Select * from tbl_Student_PrelimSubject

Select * from tbl_Grading_Period
where grade = 1;

	

Drop table tbl_Grading_Period


Select *
from tbl_Students s
inner Join tbl_Grading_Period P on s.studentId = P.Fk_studentID
--inner Join tbl_Student_MidtermSubject M on s.studentId = M.Fk_studentID
--inner Join tbl_Student_FinalSubject F on s.studentId = F.Fk_studentID

where grade = 4;
/*============ Static Data ==================*/


/* admin Data */
insert into tbl_Admin (admin_User,admin_Pass)
values('admin',123);

insert into tbl_Admin (admin_User,admin_Pass)
values('jerico',213);


/* teacher Data */


insert into tbl_TeacherAcc (firstName,lastName,email,teacher_password)
values('Jerico', 'Labajo','jecoylabs@gmail.com','123');



insert into tbl_TeacherInfo (middleName,gender,birthDate,phoneNumber,teacherId)
values('Martinez', 'male','2001/01/11','09325904438',23000);
 
insert into tbl_TeacherInfo (middleName,gender,birthDate,phoneNumber,teacherId)
values('Martinez', 'male','2001/01/11','09325904438',23001);


/*============ Retrieve ==================*/


Select * from tbl_Admin
Select * from tbl_Teacher


update tbl_Admin
set admin_User = 'jerico'
where adminId = 2;
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
	First_Grading nvarchar(30) default 'TBI',
	Second_Grading nvarchar(30) default 'TBI',
	Third_Grading nvarchar(30) default 'TBI',
	Fourth_Grading nvarchar(30) default 'TBI',
	CreatedBy nvarchar(75) not null 
);

--Sp_rename 'tbl_students.CreatedBy', 'UpdatedBy'


--ALTERED COLUMN
ALTER TABLE tbl_Students
Add UpdatedBy_f1 nvarchar(30) default 'TBI';

ALTER TABLE tbl_Students
Add UpdatedBy_sc nvarchar(30) default 'TBI';

ALTER TABLE tbl_Students
Add UpdatedBy_th nvarchar(30) default 'TBI';

ALTER TABLE tbl_Students
Add UpdatedBy_f4 nvarchar(30) default 'TBI';

;


Create table tbl_Student_FirstG_Subject(
	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	Mapeh_firstG float,
	English_firstG float,
	Math_firstG float,
	Filipino_firstG float,
	Science_firstG float,
	Period_Avg_firstG float(3),
	Period_Status_firstG nvarchar(30),
	GradeStatus nvarchar(30),
	updatedBy nvarchar(50),
	
)

Create table tbl_Student_SecondG_Subject(
	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	Mapeh_SecondG float,
	English_SecondG float,
	Math_SecondG float,
	Filipino_SecondG float,
	Science_SecondG float,
	Period_Avg_SecondG float (3),
	Period_Status_SecondG nvarchar(30),
	GradeStatus nvarchar(30),
	updatedBy nvarchar(50)
	
)

Create table tbl_Student_ThirdG_Subject(
	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	Mapeh_ThirdG float,
	English_ThirdG float,
	Math_ThirdG float,
	Filipino_ThirdG float,
	Science_ThirdG float,
	Period_Avg_ThirdG float(3),
	Period_Status_ThirdG nvarchar(30),
	GradeStatus nvarchar(30),
	updatedBy nvarchar(50)
	
)

Create table tbl_Student_FourthG_Subject(
	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	Mapeh_FourthG float,
	English_FourthG float,
	Math_FourthG float,
	Filipino_FourthG float,
	Science_FourthG float,
	Period_Avg_FourthG float(3),
	Period_Status_FourthG nvarchar(30),
	GradeStatus nvarchar(30),
	updatedBy nvarchar(50)
	
)


--STUDENT TERMS TABLE

Create Table tbl_Grading_Period(

	FK_studentID int FOREIGN KEY REFERENCES tbl_Students(studentId),
	FirstGrading_avg float(3),
	SecondGraing_avg float(3),
	ThirdGrading_avg float(3),
	FourthGrading_avg float(3),
	overall float(3),
	grade int,
	term nvarchar(30)


	
	--status
--	prelim_Status nvarchar(30),
--	midterm_Status nvarchar(30),
--	Final_Status nvarchar(30),
--	Overall_Status nvarchar(30),
);

Select * from tbl_Students

Select * from tbl_Student_PrelimSubject
where grade = 1;


Truncate Table tbl_Students
	

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
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
Create Table tbl_Grade_1_Stud(
	studentId int identity(604500,1) Primary Key,
	firstName nvarchar(50) Not Null,
	middleName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	age int,
	gender nvarchar(30),
	birthDate date Not Null,
	CreatedBy nvarchar(75) not null 
);


--GRADE 2
Create Table tbl_Grade_2_Stud(
	studentId int identity(2604500,1) Primary Key,
	firstName nvarchar(50) Not Null,
	middleName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	age int,
	gender nvarchar(30),
	birthDate date Not Null,
	CreatedBy nvarchar(75) not null 
);



--GRADE 3
Create Table tbl_Grade_3_Stud(
	studentId int identity(3604500,1) Primary Key,
	firstName nvarchar(50) Not Null,
	middleName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	age int,
	gender nvarchar(30),
	birthDate date Not Null,
	CreatedBy nvarchar(75) not null 
);



--GRADE 4
Create Table tbl_Grade_4_Stud(
	studentId int identity(4604500,1) Primary Key,
	firstName nvarchar(50) Not Null,
	middleName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	age int,
	gender nvarchar(30),
	birthDate date Not Null,
	CreatedBy nvarchar(75) not null 
);



--GRADE 5
Create Table tbl_Grade_5_Stud(
	studentId int identity(5604500,1) Primary Key,
	firstName nvarchar(50) Not Null,
	middleName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	age int,
	gender nvarchar(30),
	birthDate date Not Null,
	CreatedBy nvarchar(75) not null 
);



--GRADE 6
Create Table tbl_Grade_6_Stud(
	studentId int identity(6604500,1) Primary Key,
	firstName nvarchar(50) Not Null,
	middleName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	age int,
	gender nvarchar(30),
	birthDate date Not Null,
	CreatedBy nvarchar(75) not null 
);



--buhatig subject term table

Create table tbl_Student_PrelimSubject(
	
	Mapeh float,
	English float,
	Math float,
	Filipino float,
	Science float,
	Period_Status nvarchar(30),
	Period_Avg nvarchar(30),

	FK_grade_1_Id int FOREIGN KEY REFERENCES tbl_Grade_1_Stud(studentId),
	FK_grade_2_Id int FOREIGN KEY REFERENCES tbl_Grade_2_Stud(studentId),
	FK_grade_3_Id int FOREIGN KEY REFERENCES tbl_Grade_3_Stud(studentId),
	FK_grade_4_Id int FOREIGN KEY REFERENCES tbl_Grade_4_Stud(studentId),
	FK_grade_5_Id int FOREIGN KEY REFERENCES tbl_Grade_5_Stud(studentId),
	FK_grade_6_Id int FOREIGN KEY REFERENCES tbl_Grade_6_Stud(studentId),

)


Create table tbl_Student_MidtermSubject(
	
	Mapeh float,
	English float,
	Math float,
	Filipino float,
	Science float,
	Period_Status nvarchar(30),
	Period_Avg nvarchar(30),


	FK_grade_1_Id int FOREIGN KEY REFERENCES tbl_Grade_1_Stud(studentId),
	FK_grade_2_Id int FOREIGN KEY REFERENCES tbl_Grade_2_Stud(studentId),
	FK_grade_3_Id int FOREIGN KEY REFERENCES tbl_Grade_3_Stud(studentId),
	FK_grade_4_Id int FOREIGN KEY REFERENCES tbl_Grade_4_Stud(studentId),
	FK_grade_5_Id int FOREIGN KEY REFERENCES tbl_Grade_5_Stud(studentId),
	FK_grade_6_Id int FOREIGN KEY REFERENCES tbl_Grade_6_Stud(studentId),

)


Create table tbl_Student_FinaklSubject(
	
	Mapeh float,
	English float,
	Math float,
	Filipino float,
	Science float,
	Period_Status nvarchar(30),
	Period_Avg nvarchar(30),

	
	FK_grade_1_Id int FOREIGN KEY REFERENCES tbl_Grade_1_Stud(studentId),
	FK_grade_2_Id int FOREIGN KEY REFERENCES tbl_Grade_2_Stud(studentId),
	FK_grade_3_Id int FOREIGN KEY REFERENCES tbl_Grade_3_Stud(studentId),
	FK_grade_4_Id int FOREIGN KEY REFERENCES tbl_Grade_4_Stud(studentId),
	FK_grade_5_Id int FOREIGN KEY REFERENCES tbl_Grade_5_Stud(studentId),
	FK_grade_6_Id int FOREIGN KEY REFERENCES tbl_Grade_6_Stud(studentId),

)
-----------------------wala pa ni ma exec
--STUDENT TERMS TABLE

Create Table tbl_Grade_Period(
	prelim float,
	midterm float,
	final float,
	overall float,
	
	--status
	prelim_Status nvarchar(30),
	midterm_Status nvarchar(30),
	Final_Status nvarchar(30),
	Overall_Status nvarchar(30),

	FK_grade_1_Id int FOREIGN KEY REFERENCES tbl_Grade_1_Stud(studentId),
	FK_grade_2_Id int FOREIGN KEY REFERENCES tbl_Grade_2_Stud(studentId),
	FK_grade_3_Id int FOREIGN KEY REFERENCES tbl_Grade_3_Stud(studentId),
	FK_grade_4_Id int FOREIGN KEY REFERENCES tbl_Grade_4_Stud(studentId),
	FK_grade_5_Id int FOREIGN KEY REFERENCES tbl_Grade_5_Stud(studentId),
	FK_grade_6_Id int FOREIGN KEY REFERENCES tbl_Grade_6_Stud(studentId),
	
);

Select * from tbl_Grade_1_Stud

Select * from tbl_TeacherInfo



Drop table tbl_Grade_1_Stud


Select *
from tbl_TeacherAcc acc
inner Join tbl_TeacherInfo inf on acc.teacherId = inf.FK_teacherId


/*============ Static Data ==================*/


/* admin Data */
insert into tbl_Admin (admin_User,admin_Pass)
values('admin',123);

insert into tbl_Admin (admin_User,admin_Pass)
values('jerico',213);

insert into tbl_Admin (admin_User,admin_Pass)
values('jane','belaniso');


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
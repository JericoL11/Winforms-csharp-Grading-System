/*============ Table ==================*/

Create Table tbl_Admin(
	adminId int identity(1,1) Primary Key,
	admin_User nvarchar(50),
	admin_Pass nvarchar(50)
)



Create Table tbl_Teacher(
	teacherId int identity(200,1) Primary Key,
	teacher_User nvarchar(50),
	teacher_Pass nvarchar(50)
)

drop table tbl_Teacher

/*============ Static Data ==================*/


/* admin Data */
insert into tbl_Admin (admin_User,admin_Pass)
values('admin',123);

insert into tbl_Admin (admin_User,admin_Pass)
values('jerico',213);

insert into tbl_Admin (admin_User,admin_Pass)
values('jane','belaniso');


/* teacher Data */
insert into tbl_Teacher (teacher_User,teacher_Pass)
values('teacher',123);

insert into tbl_Teacher (teacher_User,teacher_Pass)
values('flory', 'mae');
/*============ Retrieve ==================*/


Select * from tbl_Admin
Select * from tbl_Teacher


update tbl_Admin
set admin_User = 'jerico'
where adminId = 2;
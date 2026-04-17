create database Hospital

use Hospital

create table Doctors(
Id int primary key identity(1,1),
Name nvarchar(100) not null,
Specialization nvarchar(100) default '---',
Phone varchar(15)
)

create table Patients(
Id int primary key identity(1,1),
Name nvarchar(100) not null,
Age int not null,
Gender nvarchar(10) not null,
Phone varchar(15),
)


insert into Doctors(Name,Specialization,Phone)
values
('Ali','Cardiology','050-230-10-20'),
('Vahid','Reanimasiya','070-734-98-07'),
('Mahir','Nevrpotologiya','090-999-99-99'),
('Konul','Neontologiya','055-231-76-97'),
('Bulul','Cardiology','055-231-76-97')

insert into Patients(Name,Age,Gender,Phone)
values
('Anar',19,'male','055-514-15-54'),
('Hesen',19,'male','077-444-44-44'),
('Mehdi',20,'male','050-342-87-95'),
('Lale',21,'female','055-908-75-57'),
('Nermin',17,'female','070-789-45-12')

update Patients set Age = 65 where id =3

Select Name,Specialization from Doctors
Select Name,Age from Patients
Select Name,Phone from Doctors
Select Name,Gender from Patients
Select Name,Age from Patients where age>30
Select Name from Doctors where Specialization = 'Cardiology'





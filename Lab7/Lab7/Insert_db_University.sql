use University

insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '�������� ������ ������������', '����������� ����������� �������������� ����������', 19, '08-12-1998', 2, '�', 8.0, BulkColumn
	from OpenRowSet(bulk N'D:\���������\�����������\4 �������\����\������������\Lab7\Lab7\Foto\Chayeuski.jpg', single_blob) as ����;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '��������� ������� ��������', '����������� ����������� �������������� ����������', 19, '12-10-1998', 2, '�', 7.6, BulkColumn
	from OpenRowSet(bulk N'D:\���������\�����������\4 �������\����\������������\Lab7\Lab7\Foto\Sazanavets.png', single_blob) as ����;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '������� ������ �������������', '����������� ����������� �������������� ����������', 18, '30-07-1999', 2, '�', 7.0, BulkColumn
	from OpenRowSet(bulk N'D:\���������\�����������\4 �������\����\������������\Lab7\Lab7\Foto\Kalishok.jpg', single_blob) as ����;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '������ ���� Ը�������', '�������������� ������� � ����������', 19, '14-08-1998', 2, '�', 7.5, BulkColumn
	from OpenRowSet(bulk N'D:\���������\�����������\4 �������\����\������������\Lab7\Lab7\Foto\Bulava.jpg', single_blob) as ����;

select * from Student
select * from [Address]
insert into [Address](StudentID, Town, [Index], Street, House, Flat) values
(100, '�����', 220006, '�����������', 21, 404),
(101, '�����', 220006, '�����������', 21, 404),
(102, '�����', 220052, '��������', 21, 312),
(103, '�����', 220006, '�����������', 21, 710)

drop table Student
drop table [Address]
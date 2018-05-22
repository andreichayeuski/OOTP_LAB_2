use University

insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Чаевский Андрей Владимирович', 'Программное обеспечение информационных технологий', 19, '08-12-1998', 2, 'м', 8.0, BulkColumn
	from OpenRowSet(bulk N'D:\Документы\Университет\4 семестр\ООТП\Лабораторные\Lab7\Lab7\Foto\Chayeuski.jpg', single_blob) as Файл;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Сазановец Ярослав Игоревич', 'Программное обеспечение информационных технологий', 19, '12-10-1998', 2, 'м', 7.6, BulkColumn
	from OpenRowSet(bulk N'D:\Документы\Университет\4 семестр\ООТП\Лабораторные\Lab7\Lab7\Foto\Sazanavets.png', single_blob) as Файл;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Калишок Богдан Александрович', 'Программное обеспечение информационных технологий', 18, '30-07-1999', 2, 'м', 7.0, BulkColumn
	from OpenRowSet(bulk N'D:\Документы\Университет\4 семестр\ООТП\Лабораторные\Lab7\Lab7\Foto\Kalishok.jpg', single_blob) as Файл;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Булова Анна Фёдоровна', 'Информационные системы и технологии', 19, '14-08-1998', 2, 'ж', 7.5, BulkColumn
	from OpenRowSet(bulk N'D:\Документы\Университет\4 семестр\ООТП\Лабораторные\Lab7\Lab7\Foto\Bulava.jpg', single_blob) as Файл;

select * from Student
select * from [Address]
insert into [Address](StudentID, Town, [Index], Street, House, Flat) values
(100, 'Минск', 220006, 'Белорусская', 21, 404),
(101, 'Минск', 220006, 'Белорусская', 21, 404),
(102, 'Минск', 220052, 'Гурского', 21, 312),
(103, 'Минск', 220006, 'Белорусская', 21, 710)

drop table Student
drop table [Address]
SET IDENTITY_INSERT Owners ON
go
Insert into Owners (OwnerId, Name) values (1, 'Единство');
Insert into Owners (OwnerId, Name) values (2, 'Шалкодин');
Insert into Owners (OwnerId, Name) values (3, 'Амавир');
Insert into Owners (OwnerId, Name) values (4, 'Адвастрой');
Insert into Owners (OwnerId, Name) values (5, 'Кировстрой');
Insert into Owners (OwnerId, Name) values (6, 'Бегельместрой');
SET IDENTITY_INSERT Owners OFF
go

SET IDENTITY_INSERT Houses ON
go
insert into Houses (HouseId, OwnerId, Price) values (1,  1, 150000);
insert into Houses (HouseId, OwnerId, Price) values (2,  2, 985333);
insert into Houses (HouseId, OwnerId, Price) values (3,  3, 63652);
insert into Houses (HouseId, OwnerId, Price) values (4,  6, 250000);
insert into Houses (HouseId, OwnerId, Price) values (5,  4, 350000);
insert into Houses (HouseId, OwnerId, Price) values (6,  5, 526000);
insert into Houses (HouseId, OwnerId, Price) values (7,  4, 3652235);
insert into Houses (HouseId, OwnerId, Price) values (8,  4, 962300);
insert into Houses (HouseId, OwnerId, Price) values (9,  2, 6362525);
insert into Houses (HouseId, OwnerId, Price) values (10, 5, 1520000);
insert into Houses (HouseId, OwnerId, Price) values (11, 6, 526000);
insert into Houses (HouseId, OwnerId, Price) values (12, 6, 125362);
insert into Houses (HouseId, OwnerId, Price) values (13, 2, 1252555);
insert into Houses (HouseId, OwnerId, Price) values (14, 1, 2521526);
insert into Houses (HouseId, OwnerId, Price) values (15, 1, 7985642);
SET IDENTITY_INSERT Houses OFF
go

SET IDENTITY_INSERT Persons ON
go
Insert into Persons (PersonId, FullName) values (1,  'Литургиев Федор Сергеевич');
Insert into Persons (PersonId, FullName) values (2,  'Анальгинов Р.В.');
Insert into Persons (PersonId, FullName) values (3,  'Ортопедов К.Ц.');
Insert into Persons (PersonId, FullName) values (4,  'Чаплин Ч.И.');
Insert into Persons (PersonId, FullName) values (5,  'Эйяфлатальёкютдлев Р.Р.');
Insert into Persons (PersonId, FullName) values (6,  'Репомицинов Л.К.');
Insert into Persons (PersonId, FullName) values (7,  'Гаусов Л.Н');
Insert into Persons (PersonId, FullName) values (8,  'Гармоникин А.К.');
Insert into Persons (PersonId, FullName) values (9,  'Датабазов Л.Д.-К.');
Insert into Persons (PersonId, FullName) values (10, 'Дурин Д.Д.');
Insert into Persons (PersonId, FullName) values (11, 'Дедикейтов Л.Д.');
Insert into Persons (PersonId, FullName) values (12, 'Шалинов К.Л.');
Insert into Persons (PersonId, FullName) values (13, 'Бабин У.Р.');
Insert into Persons (PersonId, FullName) values (14, 'Барторин К.Д.');
Insert into Persons (PersonId, FullName) values (15, 'Рынин Ц.Д.');
Insert into Persons (PersonId, FullName) values (16, 'Васин Л.Н.');
Insert into Persons (PersonId, FullName) values (17, 'Капустин');
Insert into Persons (PersonId, FullName) values (18, 'Никифоров');
Insert into Persons (PersonId, FullName) values (19, 'Васильев');
Insert into Persons (PersonId, FullName) values (20, 'Ванадин');
Insert into Persons (PersonId, FullName) values (21, 'Ладин');
Insert into Persons (PersonId, FullName) values (22, 'Кашин');
Insert into Persons (PersonId, FullName) values (23, 'Клавиатуров');
Insert into Persons (PersonId, FullName) values (24, 'Мышкин');
Insert into Persons (PersonId, FullName) values (25, 'Мишкин');
Insert into Persons (PersonId, FullName) values (26, 'Вагулин');
Insert into Persons (PersonId, FullName) values (27, 'Горностаев');
Insert into Persons (PersonId, FullName) values (28, 'Звонарёв');
Insert into Persons (PersonId, FullName) values (29, 'Завидин');
Insert into Persons (PersonId, FullName) values (30, 'Укупник');
Insert into Persons (PersonId, FullName) values (31, 'Варваров');
SET IDENTITY_INSERT Persons OFF
go


Insert into HousesPersons (HouseId, PersonId, Registration) values (8, 1, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (13, 2, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 3, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (11, 4, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 5, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (12, 6, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (5, 7, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (9, 8, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (5, 9, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (8, 10, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (8, 11, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (13, 12, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 13, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (11, 14, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (5, 15, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (12, 16, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (14, 17, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (11, 18, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (14, 19, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (9, 20, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (1, 21, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (10, 22, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (10, 23, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (13, 24, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 25, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (13, 26, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (14, 27, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 28, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (11, 29, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (15, 30, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (7, 31, 1);
Insert into HousesPersons (HouseId, PersonId, Registration) values (15, 11, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (12, 9, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (7, 27, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (12, 19, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (10, 16, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (4, 18, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (3, 28, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (1, 28, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 14, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (8, 30, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (10, 4, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (7, 8, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (14, 8, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (4, 21, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (5, 5, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (7, 31, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (8, 21, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (11, 1, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (7, 26, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (15, 14, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (1, 12, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 25, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 11, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (10, 27, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (13, 27, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 19, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (15, 26, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (6, 3, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (12, 31, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (3, 19, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 27, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (12, 13, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (10, 5, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (7, 30, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (5, 9, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (6, 16, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 3, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (6, 28, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (1, 29, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (13, 26, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (2, 6, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (13, 13, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (1, 26, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (9, 15, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (1, 21, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (15, 19, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (7, 29, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (9, 5, 0);
Insert into HousesPersons (HouseId, PersonId, Registration) values (9, 20, 0);
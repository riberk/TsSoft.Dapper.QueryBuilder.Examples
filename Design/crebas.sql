/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     27.02.2014 12:55:42                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Houses') and o.name = 'FK_HOUSES_REFERENCE_OWNERS')
alter table Houses
   drop constraint FK_HOUSES_REFERENCE_OWNERS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HousesPersons') and o.name = 'FK_HOUSESPE_REFERENCE_HOUSES')
alter table HousesPersons
   drop constraint FK_HOUSESPE_REFERENCE_HOUSES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HousesPersons') and o.name = 'FK_HOUSESPE_REFERENCE_PERSONS')
alter table HousesPersons
   drop constraint FK_HOUSESPE_REFERENCE_PERSONS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Houses')
            and   type = 'U')
   drop table Houses
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HousesPersons')
            and   type = 'U')
   drop table HousesPersons
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Owners')
            and   type = 'U')
   drop table Owners
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Persons')
            and   type = 'U')
   drop table Persons
go

/*==============================================================*/
/* Table: Houses                                                */
/*==============================================================*/
create table Houses (
   HouseId              int                  identity,
   OwnerId              int                  null,
   Price                bigint               not null,
   constraint PK_HOUSES primary key (HouseId)
)
go

/*==============================================================*/
/* Table: HousesPersons                                         */
/*==============================================================*/
create table HousesPersons (
   HouseId              int                  null,
   PersonId             int                  null,
   Registration         bit                  not null
)
go

/*==============================================================*/
/* Table: Owners                                                */
/*==============================================================*/
create table Owners (
   OwnerId              int                  identity,
   Name                 nvarchar(400)        not null,
   constraint PK_OWNERS primary key (OwnerId)
)
go

/*==============================================================*/
/* Table: Persons                                               */
/*==============================================================*/
create table Persons (
   PersonId             int                  identity,
   FullName             nvarchar(400)        not null,
   constraint PK_PERSONS primary key (PersonId)
)
go

alter table Houses
   add constraint FK_HOUSES_REFERENCE_OWNERS foreign key (OwnerId)
      references Owners (OwnerId)
go

alter table HousesPersons
   add constraint FK_HOUSESPE_REFERENCE_HOUSES foreign key (HouseId)
      references Houses (HouseId)
go

alter table HousesPersons
   add constraint FK_HOUSESPE_REFERENCE_PERSONS foreign key (PersonId)
      references Persons (PersonId)
go


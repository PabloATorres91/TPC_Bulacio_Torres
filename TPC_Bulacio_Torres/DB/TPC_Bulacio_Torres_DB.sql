CREATE DATABASE TPC_Bulacio_Torres_DB
GO
USE TPC_Bulacio_Torres_DB
GO
CREATE TABLE Country(
    IDCountry int not null primary key identity (1,1),
    CountryName varchar (100) not null unique
)
GO
CREATE TABLE City(
    IDCity int not null primary key identity(1,1),
    CityName varchar(100) not null,
    IDCountry int not null foreign key references Country(IDCountry)
)
GO

CREATE TABLE ZipCode(
	IDZipCode varchar(25) not null primary key,
	IDCity int not null foreign key references City(IDCity)
)
GO
CREATE TABLE Person(
	IDPerson varchar(25) primary key not null,
	PersonName varchar(50) not null,
	PersonLastname varchar(50) not null,
	PersonBirthday date not null check(PersonBirthday < GETDATE()),
	PersonAddress varchar(100) not null,
	IDZipCode varchar(25) not null foreign key references ZipCode(IDZipCode)
)
GO
CREATE TABLE Contact(
    IDPerson varchar(25) foreign key references Person(IDPerson),
	ContactPhone varchar(50) null,
    ContactCellphone varchar(50) null,
    ContactEmail varchar(100) null
)

GO
CREATE TABLE Section(
    IDSection int not null primary key identity(1,1),
    SectionName varchar(100)
)
GO
CREATE TABLE Speciality(
    IDSpeciality int not null primary key identity(1,1),
    SpecialityName varchar(100)
)
GO
CREATE TABLE IndustrialPlant(
    IDIndustrialPlant int not null primary key identity(1,1),
    IndustrialPlantName varchar(100),
    IndustrialPlantAddress varchar(100) not null,
	IDZipCode varchar(25) not null foreign key references ZipCode(IDZipCode)
)
GO
CREATE TABLE Employee(
    IDEmployee int not null primary key identity (1,1),
    IDPerson varchar(25) not null foreign key references Person(IDPerson),
    EmployeeDate datetime not null check (EmployeeDate <= GETDATE()),
    IDIndustrialPlant int not null foreign key references IndustrialPlant(IDIndustrialPlant),
    IDSection int not null foreign key references Section(IDSection),
    IDSpeciality int not null foreign key references Speciality(IDSpeciality),
    EmployeeStatus bit not null default (1)
)
GO
CREATE TABLE ProductionLine(
	IDProductionLine int not null primary key identity (1,1),
	ProductionLineName varchar(100) not null
)
GO
CREATE TABLE Machine(
	IDMachine int not null primary key identity (1,1),
	IDProductionLine int null foreign key references ProductionLine(IDProductionLine),
	MachineName varchar (100) not null,
	MachineModel varchar (100) not null,
	MachineSerialNumber varchar (50) not null unique
)
GO
CREATE TABLE Part(
	IDPart int not null primary key identity (1,1),
	IDMachine int null foreign key references Machine(IDMachine),
	PartName varchar (100) not null,
	PartDescription varchar (300) null
)
GO 
CREATE TABLE StopCode(
	IDStopCode int not null primary key identity (1,1),
	StopCodeName varchar(100) not null unique
)
GO 
CREATE TABLE Profiles(
	IDProfiles int not null primary key identity (1,1),
	ProfilesName varchar (50) not null unique
)
GO
CREATE TABLE Users(
	IDUsers int not null primary key identity (1,1) ,
	IDProfiles int not null foreign key references Profiles(IDProfiles),
	IDEmployee int null foreign key references Employee(IDEmployee),
	UsersName varchar (50) not null unique,
	UsersEmail varchar (100) not null unique,
	UsersPass varchar (100) not null,
	UsersDate datetime not null check (UsersDate <= GETDATE()),
	UserState bit not null
)
GO
CREATE TABLE Logins(
	IDLogins bigint not null primary key identity (1,1),
	IDUsers int not null foreign key references Users(IDUsers),
	LoginsDateIn datetime not null,
	LoginsDateOut datetime not null
) 
GO
CREATE TABLE StopLog(
	IDStopLog bigint not null primary key identity(1,1),
	IDMachine int not null foreign key references Machine(IDMachine),
	IDStopCode int not null foreign key references StopCode(IDStopCode),
	IDUsers int not null foreign key references Users(IDUsers),
	StopLogBegin datetime not null,
	StopLogFinish datetime not null,
	StopLogObservation varchar (1000) null
)

GO
ALTER TABLE Logins add constraint CHK_LoginsDateIn check (LoginsDateIn <= GETDATE())
ALTER TABLE Logins add constraint CHK_LoginsDateOut check (LoginsDateOut > LoginsDateIn) 
ALTER TABLE StopLog add constraint CHK_StopLogBegin check (StopLogBegin <= GETDATE())
ALTER TABLE StopLog add constraint CHK_StopLogFinish check (StopLogFinish > StopLogBegin)
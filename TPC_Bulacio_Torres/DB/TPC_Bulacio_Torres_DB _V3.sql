CREATE DATABASE TPC_Bulacio_Torres_DB
GO
USE TPC_Bulacio_Torres_DB
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
	MachineSerialNumber varchar (50) not null unique,
	MachineStatus bit not null default (1)
)
GO
CREATE TABLE Part(
	IDPart int not null primary key identity (1,1),
	IDMachine int null foreign key references Machine(IDMachine),
	PartName varchar (100) not null,
	PartDescription varchar (300) null,
	PartStatus bit not null default (1)
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
CREATE TABLE Turn(
	IDTurn int not null primary key identity (1,1),
	TurnName varchar(25) not null
)
GO
CREATE TABLE StopLog(
	IDStopLog bigint not null primary key identity(1,1),
	IDMachine int not null foreign key references Machine(IDMachine),
	IDStopCode int not null foreign key references StopCode(IDStopCode),
	IDUsers int not null foreign key references Users(IDUsers),
	IDTurn int not null foreign key references Turn(IDTurn),
	StopLogBegin datetime not null,
	StopLogFinish datetime not null,
	StopLogObservation varchar (1000) null
)

GO
CREATE TRIGGER TR_DELETE_MACHINE ON Machine
INSTEAD OF DELETE
AS
BEGIN
	UPDATE Machine SET MachineStatus = 0 WHERE IDMachine IN (SELECT IDMachine FROM deleted)
END


GO
CREATE TRIGGER TR_DELETE_USERS ON Users
INSTEAD OF DELETE
AS
BEGIN
	UPDATE Users SET UserState = 0 WHERE IDUsers IN (SELECT IDUsers FROM deleted)
END

GO
CREATE TRIGGER TR_DELETE_PART ON Part
INSTEAD OF DELETE
AS
BEGIN
	UPDATE Part SET PartStatus = 0 WHERE IDPart IN (SELECT IDPart FROM deleted)
END
GO
ALTER TABLE Logins add constraint CHK_LoginsDateIn check (LoginsDateIn <= GETDATE())
ALTER TABLE Logins add constraint CHK_LoginsDateOut check (LoginsDateOut > LoginsDateIn) 
ALTER TABLE StopLog add constraint CHK_StopLogBegin check (StopLogBegin <= GETDATE())
ALTER TABLE StopLog add constraint CHK_StopLogFinish check (StopLogFinish > StopLogBegin)
USE [TPC_Bulacio_Torres_DB]
GO
SET IDENTITY_INSERT [dbo].[Country] ON
GO
INSERT [dbo].[Country] ([IDCountry], [CountryName]) VALUES (1, N'Argentina')
GO
INSERT [dbo].[Country] ([IDCountry], [CountryName]) VALUES (2, N'Uruguay')
GO
INSERT [dbo].[Country] ([IDCountry], [CountryName]) VALUES (3, N'Chile')
GO
INSERT [dbo].[Country] ([IDCountry], [CountryName]) VALUES (4, N'Estados Unidos')
GO
INSERT [dbo].[Country] ([IDCountry], [CountryName]) VALUES (5, N'Italia')
GO
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
SET IDENTITY_INSERT [dbo].[City] ON 
GO
INSERT [dbo].[City] ([IDCity], [CityName], [IDCountry]) VALUES (1, N'Buenos Aires', 1)
GO
INSERT [dbo].[City] ([IDCity], [CityName], [IDCountry]) VALUES (2, N'Punta del Este', 2)
GO
INSERT [dbo].[City] ([IDCity], [CityName], [IDCountry]) VALUES (3, N'Roma', 5)
GO
INSERT [dbo].[City] ([IDCity], [CityName], [IDCountry]) VALUES (4, N'Punta Arena', 3)
GO
INSERT [dbo].[City] ([IDCity], [CityName], [IDCountry]) VALUES (5, N'New York', 4)
GO
SET IDENTITY_INSERT [dbo].[City] OFF
GO
INSERT [dbo].[ZipCode] ([IDZipCode], [IDCity]) VALUES (N'B1610ARS', 1) 
GO 
INSERT [dbo].[ZipCode] ([IDZipCode], [IDCity]) VALUES (N'B1618ARS',1) 
GO 
INSERT [dbo].[ZipCode] ([IDZipCode], [IDCity]) VALUES (N'T1463GFR',5) 
GO 
INSERT [dbo].[ZipCode] ([IDZipCode], [IDCity]) VALUES (N'R1587MKF',3) 
GO 
INSERT [dbo].[ZipCode] ([IDZipCode], [IDCity]) VALUES (N'B1621KGF',1)
GO
INSERT [dbo].[ZipCode] ([IDZipCode], [IDCity]) VALUES (N'C1120PFB',2) 
GO
INSERT [dbo].[Person] ([IDPerson], [PersonName], [PersonLastname], [PersonBirthday], [PersonAddress], [IDZipCode]) VALUES (N'27244022', N'Pablo', N'Bulacio', CAST(N'1979-07-24' as date), N'Olavarria 2843', N'B1610ARS')
GO
INSERT [dbo].[Person] ([IDPerson], [PersonName], [PersonLastname], [PersonBirthday], [PersonAddress], [IDZipCode]) VALUES (N'11111111', N'Pablo', N'Torres', CAST(N'2000-05-22' as date), N'Calle 1 1111', N'B1621KGF')
GO
INSERT [dbo].[Person] ([IDPerson], [PersonName], [PersonLastname], [PersonBirthday], [PersonAddress], [IDZipCode]) VALUES (N'22222222', N'Diego', N'Gonzalez', CAST(N'2002-06-01' as date), N'Calle 2 2222', N'C1120PFB')
GO
INSERT [dbo].[Person] ([IDPerson], [PersonName], [PersonLastname], [PersonBirthday], [PersonAddress], [IDZipCode]) VALUES (N'33333333', N'Esteban', N'Ferreyra', CAST(N'1986-05-25' as date), N'Calle 3 3333', N'T1463GFR')
GO
INSERT [dbo].[Person] ([IDPerson], [PersonName], [PersonLastname], [PersonBirthday], [PersonAddress], [IDZipCode]) VALUES (N'44444444', N'Maximiliano', N'Paz', CAST(N'1999-09-30'as date), N'Calle 4 4444', N'R1587MKF')
GO
INSERT [dbo].[Person] ([IDPerson], [PersonName], [PersonLastname], [PersonBirthday], [PersonAddress], [IDZipCode]) VALUES (N'55555555', N'Maria Cristina', N'Riquelme', CAST(N'1942-07-24' as date), N'Calle 5 5555', N'B1618ARS')
GO
INSERT [dbo].[Contact] ([IDPerson], [ContactPhone], [ContactCellphone], [ContactEmail]) VALUES(N'27244022',null, N'1133668802',N'pablofbulacio@hotmail.com')
GO
INSERT [dbo].[Contact] ([IDPerson], [ContactPhone], [ContactCellphone], [ContactEmail]) VALUES(N'55555555',N'1125365965', N'1187569254',null)
GO
INSERT [dbo].[Contact] ([IDPerson], [ContactPhone], [ContactCellphone], [ContactEmail]) VALUES(N'33333333',N'1163598752', null,N'pichincha@gmail.com')
GO
INSERT [dbo].[Contact] ([IDPerson], [ContactPhone], [ContactCellphone], [ContactEmail]) VALUES(N'11111111',null, N'1158965823',N'elmejor01@hotmail.com')
GO
INSERT [dbo].[Contact] ([IDPerson], [ContactPhone], [ContactCellphone], [ContactEmail]) VALUES(N'22222222',N'1163265369', N'1133895528',N'aguanteriver2018@yahoo.com.ar')
GO 
SET IDENTITY_INSERT [dbo].[Section] ON
GO
INSERT [dbo].[Section]([IDSection], [SectionName]) VALUES (1, N'Departamento de Mantenimiento')
GO
INSERT [dbo].[Section]([IDSection], [SectionName]) VALUES (2, N'Departamento de Compras')
GO
INSERT [dbo].[Section]([IDSection], [SectionName]) VALUES (3, N'Departamento de Ventas')
GO
INSERT [dbo].[Section]([IDSection], [SectionName]) VALUES (4, N'Administracion')
GO
INSERT [dbo].[Section]([IDSection], [SectionName]) VALUES (5, N'Expedición')
GO
INSERT [dbo].[Section]([IDSection], [SectionName]) VALUES (6, N'Marketing')
GO
INSERT [dbo].[Section]([IDSection], [SectionName]) VALUES (7, N'Gerencia General')
GO
SET IDENTITY_INSERT [dbo].[Section] OFF
GO 
SET IDENTITY_INSERT [dbo].[Speciality] ON
GO
INSERT [dbo].[Speciality]([IDSpeciality], [SpecialityName]) VALUES (1, N'I.T.')
GO
INSERT [dbo].[Speciality]([IDSpeciality], [SpecialityName]) VALUES (2, N'Administrativo Técnico')
GO
INSERT [dbo].[Speciality]([IDSpeciality], [SpecialityName]) VALUES (3, N'Administrativo')
GO
INSERT [dbo].[Speciality]([IDSpeciality], [SpecialityName]) VALUES (4, N'Jefe de Área')
GO
INSERT [dbo].[Speciality]([IDSpeciality], [SpecialityName]) VALUES (5, N'Supervisor')
GO
INSERT [dbo].[Speciality]([IDSpeciality], [SpecialityName]) VALUES (6, N'Técnico')
GO
INSERT [dbo].[Speciality]([IDSpeciality], [SpecialityName]) VALUES (7, N'Operador')
GO
SET IDENTITY_INSERT [dbo].[Speciality] OFF
GO
SET IDENTITY_INSERT [dbo].[IndustrialPlant] ON
GO
INSERT [dbo].[IndustrialPlant]([IDIndustrialPlant], [IndustrialPlantName], [IndustrialPlantAddress], [IDZipCode]) VALUES(1, N'LaterCer', N'Calle 12 1450', N'B1610ARS')
GO
INSERT [dbo].[IndustrialPlant]([IDIndustrialPlant], [IndustrialPlantName], [IndustrialPlantAddress], [IDZipCode]) VALUES(2, N'Alusud', N'Colectora Oeste 32680', N'B1618ARS')
GO
INSERT [dbo].[IndustrialPlant]([IDIndustrialPlant], [IndustrialPlantName], [IndustrialPlantAddress], [IDZipCode]) VALUES(3, N'Showcenter S.R.L.', N'Colectora Oeste 25625', N'B1621KGF')
GO
INSERT [dbo].[IndustrialPlant]([IDIndustrialPlant], [IndustrialPlantName], [IndustrialPlantAddress], [IDZipCode]) VALUES(4, N'Lequipe Monteur', N'Calle 13 666', N'T1463GFR')
GO
INSERT [dbo].[IndustrialPlant]([IDIndustrialPlant], [IndustrialPlantName], [IndustrialPlantAddress], [IDZipCode]) VALUES(5, N'Comasa S.A.', N'Belgrano 2658', N'B1618ARS')
GO
SET IDENTITY_INSERT [dbo].[IndustrialPlant] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
GO
INSERT [dbo].[Employee] ([IDEmployee], [IDPerson], [EmployeeDate], [IDIndustrialPlant], [IDSection], [IDSpeciality], [EmployeeStatus]) VALUES (1,N'22222222', CAST(N'2018-01-25' AS date), 1, 1, 6, 1)
GO
INSERT [dbo].[Employee] ([IDEmployee], [IDPerson], [EmployeeDate], [IDIndustrialPlant], [IDSection], [IDSpeciality], [EmployeeStatus]) VALUES (2,N'33333333', CAST(N'2018-01-25' AS date), 1, 4, 3, 1)
GO
INSERT [dbo].[Employee] ([IDEmployee], [IDPerson], [EmployeeDate], [IDIndustrialPlant], [IDSection], [IDSpeciality], [EmployeeStatus]) VALUES (3,N'55555555', CAST(N'2018-01-25' AS date), 1, 7, 4, 1)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductionLine] ON
GO
INSERT [dbo].[ProductionLine]([IDProductionLine], [ProductionLineName]) VALUES (1, N'Linea de Producción 1')
GO
INSERT [dbo].[ProductionLine]([IDProductionLine], [ProductionLineName]) VALUES (2, N'Linea de Producción 2')
GO
SET IDENTITY_INSERT [dbo].[ProductionLine] OFF
GO
SET IDENTITY_INSERT [dbo].[Machine] ON
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber]) VALUES (1, 1, N'Extrusora 1', N'850TN', N'RS-0250')
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber]) VALUES (2, 2, N'Extrusora 2', N'750TN', N'RS-0150')
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber]) VALUES (3, 1, N'Apliladora 1', N'AP-100', N'AR-0250')
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber]) VALUES (4, 2, N'Apiladora 2', N'AP-100', N'AR-0350')
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber]) VALUES (5, 1, N'Desapiladora 1', N'DES-50', N'DRA-0150')
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber]) VALUES (6, 2, N'Desapiladora 2', N'DES-75', N'DRA-0050')
GO
SET IDENTITY_INSERT [dbo].[Machine] OFF
GO
SET IDENTITY_INSERT [dbo].[Part] ON
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription]) VALUES (1, 1, N'Batea', null)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription]) VALUES (2, 1, N'Cámara de vacío', null)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription]) VALUES (3, 1, N'Cabezal de Extrusión', null)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription]) VALUES (4, 2, N'Bancal', null)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription]) VALUES (5, 2, N'Cadenas', null)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription]) VALUES (6, 3, N'Pinzas', null)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription]) VALUES (7, 3, N'Cilindro Hidráulico', null)
GO
SET IDENTITY_INSERT [dbo].[Part] OFF
GO
SET IDENTITY_INSERT [dbo].[StopCode] ON
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName]) VALUES (1, N'Falta de Energía Eléctrica')
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName]) VALUES (2, N'Falta de Energía Neumática')
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName]) VALUES (3, N'Falta de Gas')
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName]) VALUES (4, N'Parada Programada')
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName]) VALUES (5, N'Parada No Programada')
GO
SET IDENTITY_INSERT [dbo].[StopCode] OFF
GO
SET IDENTITY_INSERT [dbo].[Profiles] ON
GO
INSERT [dbo].[Profiles]([IDProfiles], [ProfilesName]) VALUES (1, N'Administrador')
GO
INSERT [dbo].[Profiles]([IDProfiles], [ProfilesName]) VALUES (2, N'Jefe de Área')
GO
INSERT [dbo].[Profiles]([IDProfiles], [ProfilesName]) VALUES (3, N'Supervisor')
GO
INSERT [dbo].[Profiles]([IDProfiles], [ProfilesName]) VALUES (4, N'Técnico')
GO
INSERT [dbo].[Profiles]([IDProfiles], [ProfilesName]) VALUES (5, N'Operador')
GO
SET IDENTITY_INSERT [dbo].[Profiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON
GO
INSERT [dbo].[Users]([IDUsers], [IDProfiles], [IDEmployee], [UsersName], [UsersEmail], [UsersPass], [UsersDate]) VALUES (1, 1, null, N'PabloB', N'pablofbulacio@gmail.com', N'0000', CAST(N'2021-06-20' as date))
GO
INSERT [dbo].[Users]([IDUsers], [IDProfiles], [IDEmployee], [UsersName], [UsersEmail], [UsersPass], [UsersDate]) VALUES (2, 1, null, N'PabloT', N'pablotorres@gmail.com', N'0001', CAST(N'2021-06-20' as date))
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Logins] ON
GO
INSERT [dbo].[Logins] ([IDLogins], [IDUsers], [LoginsDateIn], [LoginsDateOut]) VALUES (1, 1, CAST(N'2021-06-20' as date), CAST(N'2021-06-21' as date))
GO
INSERT [dbo].[Logins] ([IDLogins], [IDUsers], [LoginsDateIn], [LoginsDateOut]) VALUES (2, 2, CAST(N'2021-06-20' as date), CAST(N'2021-06-21' as date))
GO
SET IDENTITY_INSERT [dbo].[Logins] OFF
GO
SET IDENTITY_INSERT [dbo].[StopLog] ON
GO
INSERT [dbo].[StopLog]([IDStopLog], [IDMachine], IDStopCode, [IDUsers], [StopLogBegin], [StopLogFinish], [StopLogObservation]) VALUES (1, 4, 1, 1, CAST(N'20210620 01:00:00' as datetime), CAST(N'20210620 01:20:12' as datetime), N'Corto circuito en tablero principal.' )
GO
INSERT [dbo].[StopLog]([IDStopLog], [IDMachine], IDStopCode, [IDUsers], [StopLogBegin], [StopLogFinish], [StopLogObservation]) VALUES (2, 4, 3, 1, CAST(N'20210620 03:15:25' as datetime), CAST(N'20210620 04:35:23' as datetime), N'No pagaron la boleta de gas.')
GO
INSERT [dbo].[StopLog]([IDStopLog], [IDMachine], IDStopCode, [IDUsers], [StopLogBegin], [StopLogFinish], [StopLogObservation]) VALUES (3, 2, 2, 2, CAST(N'20210621 12:25:36' as datetime), CAST(N'20210621 14:27:18' as datetime), N'Se paró el compresor número 1.')
GO
INSERT [dbo].[StopLog]([IDStopLog], [IDMachine], IDStopCode, [IDUsers], [StopLogBegin], [StopLogFinish], [StopLogObservation]) VALUES (4, 2, 4, 2, CAST(N'20210621 16:45:36' as datetime), CAST(N'20210621 16:55:24' as datetime), N'Limpieza del sector.')
GO
SET IDENTITY_INSERT [dbo].[StopLog] OFF
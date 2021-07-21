USE [TPC_Bulacio_Torres_DB]
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
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber], [MachineStatus]) VALUES (1, 1, N'Extrusora 1', N'850TN', N'RS-0250',1)
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber], [MachineStatus]) VALUES (2, 2, N'Extrusora 2', N'750TN', N'RS-0150',1)
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber], [MachineStatus]) VALUES (3, 1, N'Apliladora 1', N'AP-100', N'AR-0250',1)
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber], [MachineStatus]) VALUES (4, 2, N'Apiladora 2', N'AP-100', N'AR-0350',1)
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber], [MachineStatus]) VALUES (5, 1, N'Desapiladora 1', N'DES-50', N'DRA-0150',1)
GO
INSERT [dbo].[Machine]([IDMachine], [IDProductionLine], [MachineName], [MachineModel], [MachineSerialNumber], [MachineStatus]) VALUES (6, 2, N'Desapiladora 2', N'DES-75', N'DRA-0050',1)
GO
SET IDENTITY_INSERT [dbo].[Machine] OFF
GO
SET IDENTITY_INSERT [dbo].[Part] ON
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription], [PartStatus]) VALUES (1, 1, N'Batea', null, 1)
GO																		
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription], [PartStatus]) VALUES (2, 1, N'Cámara de vacío', null, 1)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription], [PartStatus]) VALUES (3, 1, N'Cabezal de Extrusión', null, 1)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription], [PartStatus]) VALUES (4, 2, N'Bancal', null, 1)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription], [PartStatus]) VALUES (5, 2, N'Cadenas', null, 1)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription], [PartStatus]) VALUES (6, 3, N'Pinzas', null, 1)
GO
INSERT [dbo].[Part]([IDPart], [IDMachine], [PartName], [PartDescription], [PartStatus]) VALUES (7, 3, N'Cilindro Hidráulico', null, 1)
GO
SET IDENTITY_INSERT [dbo].[Part] OFF
GO
SET IDENTITY_INSERT [dbo].[StopCode] ON
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName], [StopCodeState]) VALUES (1, N'Falta de Energía Eléctrica', 1)
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName], [StopCodeState]) VALUES (2, N'Falta de Energía Neumática', 1)
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName], [StopCodeState]) VALUES (3, N'Falta de Gas', 1)
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName], [StopCodeState]) VALUES (4, N'Parada Programada', 1)
GO
INSERT [dbo].[StopCode] ([IDStopCode], [StopCodeName], [StopCodeState]) VALUES (5, N'Parada No Programada', 1)
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
INSERT [dbo].[Users]([IDUsers], [IDProfiles], [UsersName], [UsersEmail], [UsersPass], [UsersDate], [UserState]) VALUES (1, 1, N'PabloB', N'pablofbulacio@gmail.com', N'0000', CAST(N'2021-06-20' as date), CONVERT(bit,'True'))
GO
INSERT [dbo].[Users]([IDUsers], [IDProfiles], [UsersName], [UsersEmail], [UsersPass], [UsersDate], [UserState]) VALUES (2, 1, N'PabloT', N'pablotorres@gmail.com', N'0001', CAST(N'2021-06-20' as date), CONVERT(bit,'True'))
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
SET IDENTITY_INSERT [dbo].[Turn] ON
GO
INSERT [dbo].[Turn] ([IDTurn], [TurnName]) VALUES (1, N'Mañana')
GO
INSERT [dbo].[Turn] ([IDTurn], [TurnName]) VALUES (2, N'Tarde')
GO
INSERT [dbo].[Turn] ([IDTurn], [TurnName]) VALUES (3, N'Noche')
GO
SET IDENTITY_INSERT [dbo].[Turn] OFF
GO
SET IDENTITY_INSERT [dbo].[StopLog] ON
GO
INSERT [dbo].[StopLog]([IDStopLog], [IDMachine], IDStopCode, [IDUsers], [IDTurn], [StopLogBegin], [StopLogFinish], [StopLogObservation], [StopLogStatus]) VALUES (1, 4, 1, 1, 3, CAST(N'20210620 01:00:00' as datetime), CAST(N'20210620 01:20:12' as datetime), N'Corto circuito en tablero principal.', 1)
GO
INSERT [dbo].[StopLog]([IDStopLog], [IDMachine], IDStopCode, [IDUsers], [IDTurn], [StopLogBegin], [StopLogFinish], [StopLogObservation], [StopLogStatus]) VALUES (2, 4, 3, 1, 3, CAST(N'20210620 03:15:25' as datetime), CAST(N'20210620 04:35:23' as datetime), N'No pagaron la boleta de gas.', 1)
GO
INSERT [dbo].[StopLog]([IDStopLog], [IDMachine], IDStopCode, [IDUsers], [IDTurn], [StopLogBegin], [StopLogFinish], [StopLogObservation], [StopLogStatus]) VALUES (3, 2, 2, 2, 2, CAST(N'20210621 14:05:36' as datetime), CAST(N'20210621 14:27:18' as datetime), N'Se paró el compresor número 1.', 1)
GO
INSERT [dbo].[StopLog]([IDStopLog], [IDMachine], IDStopCode, [IDUsers], [IDTurn], [StopLogBegin], [StopLogFinish], [StopLogObservation], [StopLogStatus]) VALUES (4, 2, 4, 2, 2, CAST(N'20210621 16:45:36' as datetime), CAST(N'20210621 16:55:24' as datetime), N'Limpieza del sector.', 1)
GO
SET IDENTITY_INSERT [dbo].[StopLog] OFF
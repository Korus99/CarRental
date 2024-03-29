﻿CREATE TABLE [dbo].[Maintenance]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [VehicleId] INT NOT NULL, 
    [MaintenanceId] INT NOT NULL, 
    [MaintStart] DATETIME NULL, 
    [MaintEnd] DATETIME NULL, 
    [Completed] BIT NOT NULL DEFAULT 0, 
    [CompletedBy] INT NULL, 
    CONSTRAINT [FK_Maintenance_ToVehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([Id]), 
    CONSTRAINT [FK_Maintenance_ToMainSchedule] FOREIGN KEY ([MaintenanceId]) REFERENCES [MaintenanceSchedule]([Id]), 
    CONSTRAINT [FK_Maintenance_ToUser] FOREIGN KEY ([CompletedBy]) REFERENCES [User]([Id])
)

CREATE TABLE [dbo].[MaintenanceSchedule]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [VehicleId] INT NOT NULL, 
    [Maintenance] VARCHAR(250) NOT NULL, 
    [DueDate] DATE NULL, 
    [DueMile] INT NULL, 
    [Recurring] BIT NOT NULL DEFAULT 0, 
    [NextDate] DATETIMEOFFSET NULL, 
    [NewMile] INT NULL, 
    CONSTRAINT [FK_MaintenanceSchedule_ToVehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([Id])
)

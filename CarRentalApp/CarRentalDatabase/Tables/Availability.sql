CREATE TABLE [dbo].[Availability]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [VehicleID] INT NOT NULL, 
    [UserID] INT NULL, 
    [StartDate] DATETIME NULL, 
    [EndDate] DATETIME NULL, 
    [Returned] BIT NULL, 
    [ReturnedDate] DATETIME NULL, 
    [MaintenanceId] INT NULL, 
    CONSTRAINT [FK_Availability_ToVehicle] FOREIGN KEY ([VehicleID]) REFERENCES [Vehicle]([Id]), 
    CONSTRAINT [FK_Availability_ToUser] FOREIGN KEY ([UserID]) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_Availability_ToTable] FOREIGN KEY ([MaintenanceId]) REFERENCES [Maintenance]([Id]) 
)

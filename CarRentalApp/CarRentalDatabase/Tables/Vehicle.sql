CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [VIN] VARCHAR(17) NOT NULL , 
    [Brand] VARCHAR(50) NULL, 
    [Make] VARCHAR(50) NULL, 
    [License] VARCHAR(10) NULL , 
    [State] NCHAR(2) NULL, 
    [Mileage] INT NOT NULL DEFAULT 0, 
    [Removed] BIT NOT NULL DEFAULT 0, 
    [Location] VARCHAR(50) NULL
)

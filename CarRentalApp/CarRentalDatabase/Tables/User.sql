CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Name] VARCHAR(30) NULL, 
    [Brand] VARBINARY(50) NULL, 
    [Make] VARBINARY(50) NULL, 
    [License] VARBINARY(50) NULL, 
    [State] VARBINARY(50) NULL, 
    [UserType] INT NOT NULL, 
    CONSTRAINT [FK_User_ToUserType] FOREIGN KEY ([UserType]) REFERENCES [UserType]([Id])
)

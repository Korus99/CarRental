CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Name] VARCHAR(30) NULL, 
    [Brand] VARCHAR(30) NULL, 
    [Make] VARCHAR(30) NULL, 
    [License] VARCHAR(50) NULL, 
    [State] VARCHAR(20) NULL, 
    [UserType] INT NOT NULL, 
    CONSTRAINT [FK_User_ToUserType] FOREIGN KEY ([UserType]) REFERENCES [UserType]([Id])
)

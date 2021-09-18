CREATE TABLE [dbo].[Table_pacientes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NULL, 
    [lastname] NVARCHAR(50) NULL, 
    [document] NVARCHAR(50) NULL, 
    [email] NVARCHAR(50) NULL, 
    [cell] NVARCHAR(50) NULL, 
    [address] NVARCHAR(50) NULL, 
    [city] NVARCHAR(50) NULL, 
    [country] NVARCHAR(50) NULL, 
    [create_at] DATE NULL, 
    [updated_at] DATE NULL
)

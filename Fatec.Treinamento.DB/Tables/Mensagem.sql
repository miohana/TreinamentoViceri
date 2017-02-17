CREATE TABLE [dbo].[Mensagem]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Assunto] VARCHAR(180) NULL, 
    [Remetente] VARCHAR(50) NULL, 
    [Destinatario] VARCHAR(50) NULL, 
    [Mensagem] VARCHAR(360) NULL, 
    [IdUsuario] INT NULL, 
    CONSTRAINT [FK_Mensagem_Usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [Usuario]([Id])
)

CREATE TABLE [dbo].[Usuario] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (100) NOT NULL,
    [Email]    VARCHAR (100) NOT NULL,
    [Senha]    VARCHAR (100) NOT NULL,
    [Ativo]    BIT           CONSTRAINT [DF_Usuario_Ativo] DEFAULT ((1)) NOT NULL,
    [IdPerfil] INT           NOT NULL,
    [CEP] NCHAR(9) NULL, 
    [Logradouro] VARCHAR(MAX) NULL, 
    [Bairro] VARCHAR(50) NULL, 
    [Numero] VARCHAR(10) NULL, 
    [Complemento] VARCHAR(MAX) NULL, 
    [Cidade] VARCHAR(50) NULL, 
    [Estado] VARCHAR(50) NULL, 
    [Pontos] INT NULL, 
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY ([IdPerfil]) REFERENCES [dbo].[Perfil] ([Id])
);




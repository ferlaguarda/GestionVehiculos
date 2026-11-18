CREATE TABLE [dbo].[Vehiculo] (
    [Id]        INT          NOT NULL,
    [Marca]     VARCHAR (50) NOT NULL,
    [Modelo]    VARCHAR (50) NULL,
    [Matricula] NCHAR (10)   NOT NULL,
    [Anio]      INT          NULL,
    CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED ([Id] ASC)
);


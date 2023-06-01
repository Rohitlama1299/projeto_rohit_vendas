CREATE TABLE [dbo].[encomendas] (
    [id]   INT        IDENTITY (1, 1)    NOT NULL ,
    [nome] VARCHAR (255) NOT NULL,
    [qtd]  INT           NULL, 
    CONSTRAINT [PK_encomendas] PRIMARY KEY ([id])
);


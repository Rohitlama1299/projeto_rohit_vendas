CREATE TABLE encomendas (
    id   INT    PRIMARY KEY    IDENTITY (1, 1)    NOT NULL ,
    nome VARCHAR (255) NOT NULL,
    qtd  INT           NULL, 
    
);



create table produtos(
    id int PRIMARY KEY identity(1,1),
    nome varchar(150) not null,
    qtd int,
	preco int
    
);

create TABLE clientes(
    id int PRIMARY KEY identity(1,1),
    nome varchar(150) not null,
    morada varchar(200),
    telefone varchar(15),
    email varchar(255) not null,
	estado varchar(255) not null
);

create TABLE funcionarios(
    id int PRIMARY KEY identity(1,1),
    nome varchar(150) not null,
	telefone int,
	nif int,
    morada varchar(200),
    email varchar(255),
    
);



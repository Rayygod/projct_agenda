CREATE DATABASE dbagenda;

USE dbagenda;

CREATE TABLE tb_usuarios(
	nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) PRIMARY KEY, 
    telefone VARCHAR(15) NOT NULL,
    senha VARCHAR(20) NOT NULL
);
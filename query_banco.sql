CREATE DATABASE Trabalho;

use Trabalho;

CREATE TABLE Pessoa(
ID_EMPRESA INT NOT NULL IDENTITY,
NOME_COMPLETO VARCHAR(50) NOT NULL,
TP_PESSOA CHAR(1) NOT NULL,
ENDERECO VARCHAR(60) NOT NULL,
CIDADE VARCHAR(40) NOT NULL,
CEP VARCHAR(9) NOT NULL,
UF CHAR(2) NOT NULL,
CNPJ_CPF VARCHAR(14) NOT NULL,
DATA_NASCIMENTO DATE NOT NULL,
CONSTRAINT pk_empresa PRIMARY KEY(ID_EMPRESA)
);

select * from Pessoa;

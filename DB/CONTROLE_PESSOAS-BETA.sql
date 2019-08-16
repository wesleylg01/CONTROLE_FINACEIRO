USE master 
DROP DATABASE CONTROLE_PESSOAL

CREATE DATABASE CONTROLE_PESSOAL
GO

USE CONTROLE_PESSOAL

CREATE TABLE PESSOA (Idpessoa	 INT IDENTITY (1,1) PRIMARY KEY,
                     nome		 VARCHAR(80),
					 datanasc	 DATETIME, 
					 estadocivil INT, 
					 telefone	 VARCHAR(15), 
					 celular	 VARCHAR(15), 
					 email		 VARCHAR(50), 
					 endereco	 VARCHAR(100), 
					 numero		 VARCHAR(10), 
					 cidade		 VARCHAR(100), 
					 uf			 VARCHAR(2), 
					 complmento  VARCHAR(100), 
					 cep         VARCHAR(8));

CREATE TABLE USUARIO (Idusuario	  INT IDENTITY (1,1) PRIMARY KEY,
                      Cod_usuario INT,
					  usuario	  VARCHAR(100),
					  senha		  VARCHAR(18),
					  idpessoa	  INT);

ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD  CONSTRAINT [S#USUARIO001] FOREIGN KEY([Idpessoa])
REFERENCES [dbo].[PESSOA] ([Idpessoa])
GO

ALTER TABLE [dbo].[USUARIO] CHECK CONSTRAINT [S#USUARIO001]
GO

CREATE TABLE CONTA_PAGAR (Idconta_pagar  INT IDENTITY (1,1) PRIMARY KEY,
                          idpessoa	     INT,
						  valor          MONEY, 
						  vencimento     DATETIME,
						  descricao      VARCHAR(255), 
						  formapagamento INT, 
						  mesreferencia  INT, 
						  anoreferencia  INT, 
						  parcelamento   BIT, 
						  totalparcelas  INT, 
						  parcelaspagas  INT, 
						  parcelasapagar INT);

ALTER TABLE [dbo].[CONTA_PAGAR]  WITH CHECK ADD  CONSTRAINT [S#CONTA_PAGAR001] FOREIGN KEY([Idpessoa])
REFERENCES [dbo].[PESSOA] ([Idpessoa])
GO

ALTER TABLE [dbo].[CONTA_PAGAR] CHECK CONSTRAINT [S#CONTA_PAGAR001]
GO

CREATE TABLE CONTA_RECEBER (Idconta_receber   INT IDENTITY (1,1) PRIMARY KEY,
                            idpessoa	      INT,
						    valor             MONEY,
							vencimento        DATETIME,
						    descricao         VARCHAR(255), 
						    formapagamento    INT, 
						    mesreferencia     INT, 
						    anoreferencia     INT, 
						    parcelamento      BIT, 
						    totalparcelas     INT, 
						    parcelasrecebidas INT, 
						    parcelasreceber   INT);

ALTER TABLE [dbo].[CONTA_RECEBER]  WITH CHECK ADD  CONSTRAINT [S#CONTA_RECEBER001] FOREIGN KEY([Idpessoa])
REFERENCES [dbo].[PESSOA] ([Idpessoa])
GO

ALTER TABLE [dbo].[CONTA_RECEBER] CHECK CONSTRAINT [S#CONTA_RECEBER001]
GO

CREATE TABLE META (Idmeta	 INT IDENTITY (1,1) PRIMARY KEY,
                   idpessoa  INT,
                   tipometa  INT, 
				   nomemeta  VARCHAR(100), 
				   descricao VARCHAR(255), 
				   prazo     DATETIME);

ALTER TABLE [dbo].[META]  WITH CHECK ADD  CONSTRAINT [S#META001] FOREIGN KEY([Idpessoa])
REFERENCES [dbo].[PESSOA] ([Idpessoa])
GO

CREATE TABLE GENERO (Idgenero INT IDENTITY (1,1) PRIMARY KEY,
					 nome     VARCHAR(100));

CREATE TABLE AUTOR (Idautor INT IDENTITY (1,1) PRIMARY KEY,
					nome    VARCHAR(100));

CREATE TABLE LIVRO (idlivro	    INT IDENTITY (1,1) PRIMARY KEY,
					Idgenero    INT,
					Idautor     INT,
					titulo      VARCHAR(100), 
					idioma      VARCHAR(40), 
					qtd_paginas INT);

ALTER TABLE [dbo].[LIVRO]  WITH CHECK ADD  CONSTRAINT [S#LIVRO001] FOREIGN KEY([Idgenero])
REFERENCES [dbo].[GENERO] ([Idgenero])
GO
ALTER TABLE [dbo].[LIVRO]  WITH CHECK ADD  CONSTRAINT [S#LIVRO002] FOREIGN KEY([Idautor])
REFERENCES [dbo].[AUTOR] ([Idautor])
GO

CREATE TABLE LEITURA (Idmeta	    INT IDENTITY (1,1) PRIMARY KEY,
					  idpessoa      INT,
					  idlivro       INT,
					  tempoleitura  TIME, 
					  avaliacao     INT, 
					  descavaliacao VARCHAR(255));

ALTER TABLE [dbo].[LEITURA]  WITH CHECK ADD  CONSTRAINT [S#LEITURA001] FOREIGN KEY([idlivro])
REFERENCES [dbo].[LIVRO] ([idlivro])
GO

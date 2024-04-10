CREATE DATABASE Agenda;

USE Agenda;

CREATE TABLE Contactos (
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Nombre] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono] [varchar](9) NOT NULL,
	[Observaciones] [varchar](500) NULL
);
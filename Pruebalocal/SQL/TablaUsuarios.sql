USE [Test]
GO

/****** Object:  Table [dbo].[Usuarios]    Script Date: 25/07/2023 3:26:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellidos] [varchar](100) NOT NULL,
	[DNI] [varchar](20) NOT NULL,
	[Carnet] [varchar](20) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO Usuarios (Nombre, Apellidos, DNI, Carnet, Telefono)
VALUES
  ('Juan', 'P�rez G�mez', '12345678A', 'B', '111111111'),
  ('Mar�a', 'G�mez L�pez', '98765432B', 'B', '222222222'),
  ('Pedro', 'L�pez Rodr�guez', '87654321C', 'B', '333333333'),
  ('Laura', 'Rodr�guez Mart�nez', '56789012D', 'B', '444444444'),
  ('Carlos', 'Mart�nez Hern�ndez', '34567890E', 'B', '555555555'),
  ('Ana', 'Hern�ndez Garc�a', '23456789F', 'B', '666666666'),
  ('Luis', 'Garc�a S�nchez', '45678901G', 'B', '777777777'),
  ('Elena', 'S�nchez Ram�rez', '65432109H', 'B', '888888888'),
  ('Javier', 'Ram�rez G�mez', '43210987I', 'B', '999999999'),
  ('Isabel', 'Torres Mart�nez', '98765432J', 'B', '101010101'),
  ('Juan', 'Garc�a L�pez', '12345678A', 'B', '123456789'),
  ('Mar�a', 'Mart�nez Rodr�guez', '98765432B', 'B', '987654321'),
  ('Pablo', 'Fern�ndez G�mez', '87654321C', 'B', '876543210'),
  ('Laura', 'Hern�ndez P�rez', '56789012D', 'B', '567890123'),
  ('Carlos', 'Gonz�lez S�nchez', '45678901E', 'B', '456789012'),
  ('Sof�a', 'Romero Torres', '34567890F', 'B', '345678901'),
  ('Alejandro', 'Jim�nez Ortega', '23456789G', 'B', '234567890'),
  ('Luc�a', 'Vargas Medina', '01234567H', 'B', '012345678'),
  ('Diego', 'Su�rez Molina', '90123456I', 'B', '901234567'),
  ('Carmen', 'Cabrera Castro', '89012345J', 'B', '890123456'),
  ('Jos�', 'Navarro Ruiz', '78901234K', 'B', '789012345'),
  ('Marta', 'Vidal Santos', '67890123L', 'B', '678901234'),
  ('Antonio', 'Moreno Guzm�n', '56789012M', 'B', '567890123'),
  ('Isabel', 'Castillo Herrera', '45678901N', 'B', '456789012'),
  ('Manuel', 'Soto Morales', '34567890O', 'B', '345678901'),
  ('Elena', 'Delgado Pe�a', '23456789P', 'B', '234567890'),
  ('Francisco', 'Ortiz Ram�rez', '12345678Q', 'B', '123456789');
USE [Test]
GO

/****** Object:  Table [dbo].[Vehiculos]    Script Date: 25/07/2023 3:32:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vehiculos](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Marca] [varchar](100) NOT NULL,
    [Modelo] [varchar](100) NOT NULL,
    [Potencia] [int] NOT NULL,
    [Categoria] [varchar](50) NOT NULL,
    [UsuarioId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Usuarios] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([Id])
GO

ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Usuarios]
GO

INSERT INTO Vehiculos (Marca, Modelo, Potencia, Categoria, UsuarioId)
VALUES
  ('Toyota', 'Corolla', 150, 'Sedán', 1),
  ('Ford', 'Mustang', 300, 'Deportivo', 2),
  ('Honda', 'Civic', 130, 'Compacto', 3),
  ('Chevrolet', 'Camaro', 350, 'Deportivo', 4),
  ('Volkswagen', 'Golf', 110, 'Compacto', 5),
  ('BMW', 'X5', 250, 'SUV', 6),
  ('Mercedes-Benz', 'C-Class', 180, 'Sedán', 1),
  ('Audi', 'A4', 190, 'Sedán', 2),
  ('Nissan', 'Altima', 140, 'Sedán', 7),
  ('Kia', 'Soul', 120, 'SUV', 8),
  ('Seat', 'Ibiza', 110, 'Compacto', 1),
  ('Renault', 'Clio', 120, 'Compacto', 2),
  ('Volkswagen', 'Golf', 150, 'Compacto', 3),
  ('Ford', 'Focus', 130, 'Compacto', 4),
  ('Peugeot', '208', 120, 'Compacto', 5),
  ('Opel', 'Corsa', 110, 'Compacto', 6),
  ('Citroën', 'C3', 115, 'Compacto', 7),
  ('Kia', 'Ceed', 140, 'Compacto', 8),
  ('Hyundai', 'i30', 135, 'Compacto', 9),
  ('Toyota', 'Yaris', 110, 'Compacto', 10),
  ('Mercedes-Benz', 'Clase A', 170, 'Compacto', 1),
  ('Audi', 'A3', 160, 'Compacto', 2),
  ('BMW', 'Serie 1', 180, 'Compacto', 3),
  ('Fiat', 'Punto', 115, 'Compacto', 4),
  ('Mazda', '3', 140, 'Compacto', 5),
  ('Skoda', 'Octavia', 150, 'Sedán', 6),
  ('Honda', 'Civic', 160, 'Sedán', 7),
  ('Subaru', 'Impreza', 170, 'Sedán', 8),
  ('Nissan', 'Sentra', 140, 'Sedán', 9),
  ('Chevrolet', 'Cruze', 130, 'Sedán', 10),
  ('Ferrari', '458 Italia', 570, 'Deportivo', 11),
  ('Porsche', '911', 580, 'Deportivo', 12),
  ('Lamborghini', 'Huracán', 610, 'Deportivo', 13),
  ('Aston Martin', 'DB11', 550, 'Deportivo', 14),
  ('McLaren', '570S', 540, 'Deportivo', 15),
  ('Lotus', 'Exige', 380, 'Deportivo', 16),
  ('Rolls-Royce', 'Phantom', 460, 'Lujo', 17),
  ('Bentley', 'Continental', 635, 'Lujo', 18),
  ('Maserati', 'Ghibli', 550, 'Lujo', 19),
  ('Jaguar', 'XF', 300, 'Lujo', 20),
  ('Audi', 'A8', 450, 'Lujo', 21),
  ('Lexus', 'LS', 415, 'Lujo', 22),
  ('Land Rover', 'Range Rover', 275, 'SUV', 23),
  ('Jeep', 'Wrangler', 285, 'SUV', 24),
  ('Ford', 'Explorer', 290, 'SUV', 25),
  ('Mitsubishi', 'Outlander', 220, 'SUV', 26),
  ('Hyundai', 'Tucson', 185, 'SUV', 27),
  ('Volvo', 'XC90', 310, 'SUV', 18),
  ('Nissan', 'Qashqai', 150, 'SUV', 19),
  ('Kia', 'Sorento', 200, 'SUV', 20);

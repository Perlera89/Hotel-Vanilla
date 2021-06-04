USE master
GO
DROP DATABASE IF exists  VanillaBD
GO
CREATE DATABASE VanillaBD
GO
USE VanillaBD
GO

CREATE TABLE TipoHabitaciones(
	idTipoHabitacion int primary key identity not null,
	tipo varchar(50) not null,
	numeroOcupantes int not null,
);


Create table Habitaciones(
	idHabitacion int primary key identity not null,
	numeroHabitacion varchar (10) not null,
	tarifa smallmoney not null,
	idTipoHabitacion_FK int REFERENCES TipoHabitaciones(idTipoHabitacion)
);

Create table Estados(
	idEstado int primary key identity not null,
	nombreEstado varchar(50) not null
);

Create table Huespedes(
	idHuesped int primary key identity not null,
	nombres varchar(50) not null,
	apellidos varchar(50)not null,
	direccion varchar(100),
	telefono varchar(20),
	correo varchar(30),
	idEstado_FK int REFERENCES Estados(idEstado)
);

Create table ManejoReservas(
	idReserva int primary key identity not null,
	fechaReserva date not null,
	fechaCheckIn date not null,
	fechaCheckOut date,
	numeroDias int not null,
	pagoAdelantado money,
	descuento smallmoney,
	total money,
	idHabitacion_FK int REFERENCES Habitaciones(idHabitacion),
	idHuesped_FK int REFERENCES Huespedes(idHuesped)
);

Create table Usuarios(
	idUsuario int primary key identity not null,
	nombre varchar(20) unique,
	correo varchar(30) unique,
	clave varchar(20),
);

Create table Sucesos(
	idSuceso int primary key identity not null,
	fechaSuceso datetime,
	tipoSuceso varchar(50),
	descripcion varchar(300)
);

--==============================================================================
-- Insertando datos
--==============================================================================

-- Insert TipoHabitaciones
INSERT INTO TipoHabitaciones VALUES('Simple', 1), ('Matrimonial', 2), ('Familiar', 5), ('Doble', 2), ('Libre', 1);

-- Insert Habitaciones
INSERT INTO Habitaciones VALUES('001-025-01', 25, 1), ('001-030-02', 30, 2), ('001-080-03', 80, 3), ('001-025-04', 25, 4), ('001-015-05', 15, 5);

-- Insert Estados
INSERT INTO Estados VALUES('Aceptada'), ('Pendiente'), ('Rechazada'), ('Vencida'), ('Cancelada'), ('Cerrada');

-- Insert Huespedes
INSERT INTO Huespedes VALUES('Virgilio', 'Pineda', 'Agua Caliente', '7738-8082', 'manuenitoo@gmail.com', 1), ('Oscar', 'Estrada', 'Nueva Concepcion', '7738-8082', 'estrada89@gmail.com', 1), ('Eduardo', 'Alas', 'La Reina', '7738-8082', 'edu_alas@gmail.com', 2);

-- Insert ManejoReservas
INSERT INTO ManejoReservas VALUES(GETDATE(), '2021-04-10', '2021-04-14', 5, 0, 15, 135, 2, 1), (GETDATE(), '2021-04-11', '2021-04-16', 6, 0, 20, 460, 3, 2), (GETDATE(), '2021-04-12', '2021-04-15', 4, 0, 0, 100, 1, 3);

--Insert Usuarios
INSERT INTO Usuarios VALUES('Perlera89', 'manuenitoo@gmail.com', 'Manu1234'), ('Minerva', 'wlian_minerva@gmail.com', 'User89'), ('Rodri503', 'rodrigo_1202@gmail.com', 'Admin503');

/*Selects
SELECT * FROM TipoHabitaciones;
SELECT * FROM Habitaciones;
SELECT * FROM Estados;
SELECT * FROM Huespedes;
SELECT * FROM ManejoReservas;
SELECT * FROM Usuarios;
*/


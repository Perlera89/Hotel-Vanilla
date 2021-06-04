--======================================================================================
-- Procedimientos almacenados para Habitaciones
--======================================================================================

-- Procedimiento para mostrar habitaciones
Create PROC sp_MostrarHabitaciones
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Habitaciones;
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarHabitaciones
go
-------------------------------------------------------------------------------------------------

--Procedimiento para insertar habitacion
CREATE PROC sp_InsertarHabitacion
@numeroHabitacion varchar (10),
@tarifa smallmoney,
@idTipoHabitacion_FK int

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Habitaciones VALUES(@numeroHabitacion, @tarifa, @idTipoHabitacion_FK)
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_InsertarHabitacion 32, 45, 2;
go
-------------------------------------------------------------------------------------------------

--Procedimiento para eliminar habitaciones
CREATE PROC sp_EliminarHabitacion
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Habitaciones WHERE idHabitacion = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_EliminarHabitacion 1
go
-------------------------------------------------------------------------------------------------

--Procedimiento de Actualizar los habitacion
CREATE PROC sp_ActualizarHabitacion
@idHabitacion int,
@numeroHabitacion varchar (10),
@tarifa smallmoney,
@idTipoHabitacion_FK int


AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Habitaciones SET 
	numeroHabitacion = @numeroHabitacion, tarifa = @tarifa, idTipoHabitacion_FK = @idTipoHabitacion_FK
	WHERE idHabitacion = @idHabitacion
END
go
-------------------------------------------------------------------------------------------------
select * from Habitaciones
--Prueba
EXEC sp_ActualizarHabitacion 2, 32, 35, 2;



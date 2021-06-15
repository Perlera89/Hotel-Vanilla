--=======================
--METODO PARA CARGAR EL CB DE GESTION DE HABITACIONES
go
Create Proc sp_TipoHabitacion
as
	Select h.idTipoHabitacion, 
	h.tipo 'Tipodehabitacion'
	from TipoHabitaciones h
go

-- Procedimiento para mostrar los tipos de habitaciones
Create Proc sp_MostrarTipoHabitaciones
as
	Select idTipoHabitacion, tipo, numeroOcupantes
	from TipoHabitaciones;
go

-- Procedimiento para insertar un tipo de habitaciones
CREATE PROC sp_InsertarTipoHabitacion
@tipo varchar (50),
@ocupantes int

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO TipoHabitaciones VALUES(@tipo, @ocupantes)
END
go

--Procedimiento para eliminar un tipo habitacion
CREATE PROC sp_EliminarTipoHabitacion
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM TipoHabitaciones WHERE idTipoHabitacion = @id
END
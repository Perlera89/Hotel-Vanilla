--======================================================================================
-- Procedimientos almacenados para ManejoReservas
--======================================================================================

-- Procedimiento para mostrar ManejoReservas
Alter PROC sp_MostrarManejoReservas
AS
BEGIN
	SET NOCOUNT ON;
	--Consulta con Inner join
	SELECT a.idReserva AS 'Id', b.nombres AS 'Nombres', b.apellidos AS 'Apellidos', c.numeroHabitacion AS 'Habitacion',
	a.fechaReserva 'Fecha reserva', a.fechaCheckIn AS 'Check in', a.fechaCheckOut AS 'Check out',
	a.numeroDias AS 'Dias', d.numeroOcupantes AS 'Ocupantes', a.pagoAdelantado AS 'Pago adelantado',
	d.tipo AS 'Tipo de habitación', a.descuento AS 'Descuento', a.total AS 'Total'
	FROM ManejoReservas AS a

	INNER JOIN Huespedes AS b ON a.idHuesped_FK = b.idHuesped
	INNER JOIN Habitaciones AS c ON a.idHabitacion_FK = c.idHabitacion
	INNER JOIN TipoHabitaciones AS d ON c.idTipoHabitacion_FK = d.idTipoHabitacion
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarManejoReservas
go
-------------------------------------------------------------------------------------------------

--Procedimiento para insertar ManejoReservas
Create PROC sp_InsertarManejoReservas
@reserva date,
@checkIn date,
@checkOut date,
@dias int,
@adelantado money,
@descuento smallmoney,
@total money,
@idHabitacion int, 
@idHuesped int 

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO ManejoReservas
	VALUES(
		@reserva, @checkIn, @checkOut, @dias, @adelantado, @descuento, 
		@total, @idHabitacion, @idHuesped
	);
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_InsertarManejoReservas '2021-07-07', '2021-05-05', '2021-05-15', 7, 1, 200, 25, 175, 3, 3, 1;
go
-------------------------------------------------------------------------------------------------

--Procedimiento para eliminar comunidades
CREATE PROC sp_EliminarManejoReservas
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM ManejoReservas WHERE idReserva = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_EliminarManejoReservas 4
go
-------------------------------------------------------------------------------------------------

--Procedimiento de Actualizar ManejoReservas
CREATE PROC sp_ActualizarManejoReservas
@id int,
@reserva date,
@checkIn date,
@checkOut date,
@dias int,
@adelantado money,
@descuento smallmoney,
@total money,
@idHabitacion int, 
@idHuesped int, 
@idPago int

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE ManejoReservas
	SET 
	fechaReserva = @reserva,
	fechaCheckIn = @checkIn,
	fechaCheckOut = @checkOut,
	numeroDias = @dias,
	pagoAdelantado = @adelantado,
	descuento = @descuento, 
	total = @total,
	idHabitacion_FK = @idHabitacion,
	idHuesped_FK = @idHuesped

	WHERE idReserva = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_ActualizarManejoReservas 5, '2021-05-07', '2021-05-05', '2021-05-15', 7, 200, 25, 175, 3, 3;
go

------------------------------------------------------------------------------------------------
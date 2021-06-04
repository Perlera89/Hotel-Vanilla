--======================================================================================
-- Procedimientos almacenados para ManejoReservas
--======================================================================================

-- Procedimiento para mostrar ManejoReservas
Create PROC sp_MostrarManejoReservas
AS
BEGIN
	SET NOCOUNT ON;
	--Consulta con Inner join
	SELECT a.idReserva AS 'Id', b.nombres AS 'Nombres', b.apellidos AS 'Apellidos', c.numeroHabitacion AS 'Habitacion',
	a.fechaReserva AS 'Fecha reserva', a.fechaCheckIn AS 'Check in', a.fechaCheckOut AS 'Check out',
	a.numeroDia AS 'Dias', a.numeroOcupantes AS 'Ocupantes', a.pagoAdelantado AS 'Pago adelantado',
	d.tipo AS 'Tipo de pago', a.descuento AS 'Descuento', a.total AS 'Total'
	FROM ManejoReservas AS a

	INNER JOIN Huespedes AS b ON a.idHuesped_FK = b.idHuesped
	INNER JOIN Habitaciones AS c ON a.idHabitacion_FK = c.idHabitacion
	INNER JOIN TipoPagos AS d ON a.idTipoPago_FK = d.idTipoPago
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarManejoReservas
Select * from ManejoReservas
go
-------------------------------------------------------------------------------------------------

--Procedimiento para insertar ManejoReservas
Alter PROC sp_InsertarManejoReservas
@reserva date,
@checkIn date,
@checkOut date,
@dias int,
@ocupantes int,
@adelantado money,
@descuento smallmoney,
@total money,
@idHabitacion int, 
@idHuesped int, 
@idPago int

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO ManejoReservas
	VALUES(
		@reserva, @checkIn, @checkOut, @dias, @ocupantes, @adelantado, @descuento, 
		@total, @idHabitacion, @idHuesped, @idPago
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
@ocupantes int,
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
	numeroDia = @dias,
	numeroOcupantes = @ocupantes,
	pagoAdelantado = @adelantado,
	descuento = @descuento, 
	total = @total,
	idHabitacion_FK = @idHabitacion,
	idHuesped_FK = @idHuesped,
	idTipoPago_FK = @idPago

	WHERE idReserva = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_ActualizarManejoReservas 5, '2021-05-07', '2021-05-05', '2021-05-15', 7, 1, 200, 25, 175, 3, 3, 1;
go

------------------------------------------------------------------------------------------------
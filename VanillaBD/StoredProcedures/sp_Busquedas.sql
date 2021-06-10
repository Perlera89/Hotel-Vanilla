
-- Procedimiento para buscar Huesped
Create PROC sp_BuscarHuesped
@buscador varchar(50)
AS

BEGIN
	SET NOCOUNT ON;
	SELECT a.idHuesped, a.nombres, a.apellidos, a.direccion, a.telefono, a.correo, b.nombreEstado
	FROM Huespedes a
	inner join Estados b ON a.idEstado_FK = b.idEstado
	WHERE a.nombres LIKE '%' + @buscador + '%' 
	or  a.apellidos LIKE '%' + @buscador + '%'
	or  b.nombreEstado LIKE '%' + @buscador + '%'
	or  a.direccion LIKE '%' + @buscador + '%'
END
GO

-- Procedimiento para buscar Habitacion
Create PROC sp_BuscarHabitacion
@buscador varchar(50)
AS

BEGIN
	SET NOCOUNT ON;
	SELECT a.idHabitacion, a.numeroHabitacion, a.tarifa, b.tipo 
	FROM Habitaciones a
	inner join TipoHabitaciones b ON a.idTipoHabitacion_FK = b.idTipoHabitacion
	WHERE a.numeroHabitacion LIKE '%' + @buscador + '%' 
	or  b.tipo LIKE '%' + @buscador + '%'
END
GO

exec sp_BuscarHabitacion 'Matrimonia'

-- Procedimiento para buscar Reservaciones
Alter PROC sp_BuscarReservacion
@buscador varchar(50)
AS

BEGIN
	SET NOCOUNT ON;
	SELECT a.idReserva AS 'Id', b.nombres AS 'Nombres', b.apellidos AS 'Apellidos', c.numeroHabitacion AS 'Habitacion',
	a.fechaReserva AS 'Fecha reserva', a.fechaCheckIn AS 'Check in', a.fechaCheckOut AS 'Check out',
	a.numeroDias AS 'Dias', d.numeroOcupantes AS 'Ocupantes', a.pagoAdelantado AS 'Pago adelantado',
	d.tipo AS 'Tipo', a.descuento AS 'Descuento', a.total AS 'Total'
	FROM ManejoReservas AS a
	INNER JOIN Huespedes AS b ON a.idHuesped_FK = b.idHuesped
	INNER JOIN Habitaciones AS c ON a.idHabitacion_FK = c.idHabitacion
	INNER JOIN TipoHabitaciones AS d ON c.idTipoHabitacion_FK = d.idTipoHabitacion
	WHERE b.nombres LIKE '%' + @buscador + '%' 
	or  b.apellidos LIKE '%' + @buscador + '%'
	or  cast(a.fechaReserva as varchar) LIKE '%' + @buscador + '%'
	or  cast(a.fechaCheckIn as varchar) LIKE '%' + @buscador + '%'
	or  d.tipo LIKE '%' + @buscador + '%'
END
GO


-- Procedimiento para buscar Sucesos
Create PROC sp_BuscarSucesos
@buscador varchar(50)
AS

BEGIN
	SET NOCOUNT ON;
	SELECT idSuceso, fechaSuceso, tipoSuceso, descripcion
	FROM Suceso 
	WHERE fechaSuceso LIKE '%' + @buscador + '%' 
	or tipoSuceso LIKE '%' + @buscador + '%'
END
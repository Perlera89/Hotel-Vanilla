--============================================================================================
-- Triggers para insertar sucesos de la tabla ManejoReservas --
--============================================================================================
use VanillaBD;
--Trigger para Insertar ManejoReservas
 
create TRIGGER tg_InsertarManejoReservas
    ON ManejoReservas
    AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombres varchar(50), @apellidos varchar(50), @reserva date, 
	@checkin date, @checkout date, @dias int, @adelantado money, @descuento money, 
	@total money, @habitacion varchar(10), @tipo varchar(50), @estado varchar(20);

	SELECT @id = i.idReserva,
	@nombres = a.nombres,
	@apellidos = a.apellidos,
	@reserva = i.fechaReserva,
	@checkin = i.fechaCheckIn,
	@checkout = i.fechaCheckOut,
	@dias = i.numeroDias,
	@adelantado = i.pagoAdelantado,
	@descuento = i.descuento,
	@total = i.total,
	@habitacion = c.numeroHabitacion,
	@tipo = d.tipo,
	@estado = b.nombreEstado

	FROM inserted i
	inner join Huespedes a on i.idHuesped_FK = a.idHuesped
	inner join Estados b on a.idEstado_FK = b.idEstado
	inner join Habitaciones c on i.idHabitacion_FK = c.idHabitacion
	inner join TipoHabitaciones d on c.idTipoHabitacion_FK = d.idTipoHabitacion

	INSERT INTO Suceso VALUES(GETDATE(), 'Manejo Reservas', 'Se ha Insertado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombre completo: ' +(@nombres+' '+@apellidos)+ 
	', Estado: ' +@estado+
	', Reserva: ' +cast(@reserva as varchar)+
	', Check In: ' +cast(@checkin as varchar)+
	', Check Out: ' +cast(@checkout as varchar)+
	', Dias: ' +cast(@dias as varchar)+
	', Pago adelantado: ' +cast(@adelantado as varchar)+
	', Descuento: ' +cast(@descuento as varchar)+
	', Total: ' +cast(@total as varchar)+
	', Habitacion: ' +@habitacion+
	' y Tipo: ' +@tipo);
END
GO

--Trigger para Actualizar Manejo Reservas
 
create TRIGGER tg_ActualizarManejoReservas
    ON ManejoReservas
    AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombres varchar(50), @apellidos varchar(50), @reserva date, 
	@checkin date, @checkout date, @dias int, @adelantado money, @descuento money, 
	@total money, @habitacion varchar(10), @tipo varchar(50), @estado varchar(20);

	SELECT @id = i.idReserva,
	@nombres = a.nombres,
	@apellidos = a.apellidos,
	@reserva = i.fechaReserva,
	@checkin = i.fechaCheckIn,
	@checkout = i.fechaCheckOut,
	@dias = i.numeroDias,
	@adelantado = i.pagoAdelantado,
	@descuento = i.descuento,
	@total = i.total,
	@habitacion = c.numeroHabitacion,
	@tipo = d.tipo,
	@estado = b.nombreEstado

	FROM inserted i
	inner join Huespedes a on i.idHuesped_FK = a.idHuesped
	inner join Estados b on a.idEstado_FK = b.idEstado
	inner join Habitaciones c on i.idHabitacion_FK = c.idHabitacion
	inner join TipoHabitaciones d on c.idTipoHabitacion_FK = d.idTipoHabitacion

	INSERT INTO Suceso VALUES(GETDATE(), 'Manejo Reservas', 'Se ha Actualizado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombre completo: ' +(@nombres+' '+@apellidos)+ 
	', Estado: ' +@estado+
	', Reserva: ' +cast(@reserva as varchar)+
	', Check In: ' +cast(@checkin as varchar)+
	', Check Out: ' +cast(@checkout as varchar)+
	', Dias: ' +cast(@dias as varchar)+
	', Pago adelantado: ' +cast(@adelantado as varchar)+
	', Descuento: ' +cast(@descuento as varchar)+
	', Total: ' +cast(@total as varchar)+
	', Habitacion: ' +@habitacion+
	' y Tipo: ' +@tipo);
END
GO
 
--Trigger para Eliminar Manejo Reservas
 
create TRIGGER tg_EliminarManejoReservas
    ON ManejoReservas
    AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombres varchar(50), @apellidos varchar(50), @reserva date, 
	@checkin date, @checkout date, @dias int, @adelantado money, @descuento money, 
	@total money, @habitacion varchar(10), @tipo varchar(50), @estado varchar(20);

	SELECT @id = i.idReserva,
	@nombres = a.nombres,
	@apellidos = a.apellidos,
	@reserva = i.fechaReserva,
	@checkin = i.fechaCheckIn,
	@checkout = i.fechaCheckOut,
	@dias = i.numeroDias,
	@adelantado = i.pagoAdelantado,
	@descuento = i.descuento,
	@total = i.total,
	@habitacion = c.numeroHabitacion,
	@tipo = d.tipo,
	@estado = b.nombreEstado

	FROM deleted i
	inner join Huespedes a on i.idHuesped_FK = a.idHuesped
	inner join Estados b on a.idEstado_FK = b.idEstado
	inner join Habitaciones c on i.idHabitacion_FK = c.idHabitacion
	inner join TipoHabitaciones d on c.idTipoHabitacion_FK = d.idTipoHabitacion

	INSERT INTO Suceso VALUES(GETDATE(), 'Manejo Reservas', 'Se ha Eliminado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombre completo: ' +(@nombres+' '+@apellidos)+ 
	', Estado: ' +@estado+
	', Reserva: ' +cast(@reserva as varchar)+
	', Check In: ' +cast(@checkin as varchar)+
	', Check Out: ' +cast(@checkout as varchar)+
	', Dias: ' +cast(@dias as varchar)+
	', Pago adelantado: ' +cast(@adelantado as varchar)+
	', Descuento: ' +cast(@descuento as varchar)+
	', Total: ' +cast(@total as varchar)+
	', Habitacion: ' +@habitacion+
	' y Tipo: ' +@tipo);
END
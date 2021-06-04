--============================================================================================
-- Triggers para insertar sucesos de la tabla Habitaciones --
--============================================================================================
use VanillaBD;
--Trigger para Insertar Habitacion
 
create TRIGGER tg_InsertarHabitacion
    ON Habitaciones
    AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @habitacion varchar(10), 
	@tarifa money, @tipo varchar(50), @ocupantes int;

	SELECT @id = i.idHabitacion,
	@habitacion = i.numeroHabitacion,
	@tarifa = i.tarifa,
	@tipo = a.tipo,
	@ocupantes = a.numeroOcupantes
	FROM inserted i
	inner join TipoHabitaciones a
	on i.idTipoHabitacion_FK = a.idTipoHabitacion

	INSERT INTO Suceso VALUES(GETDATE(), 'Habitaciones', 'Se ha Insertado el registro con Id: ' + cast(@id as varchar)+ 
	', Numero habitacion: ' +@habitacion+ 
	', Tarifa: ' +cast(@tarifa as varchar)+
	', Tipo habitacion: ' +@tipo+
	' y Numero ocupantes: ' +cast(@ocupantes as varchar));
END
GO

--Trigger para Actualizar Habitacion
 
create TRIGGER tg_ActualizarHabitacion
    ON Habitaciones
    AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @habitacion varchar(10), 
	@tarifa money, @tipo varchar(50), @ocupantes int;

	SELECT @id = i.idHabitacion,
	@habitacion = i.numeroHabitacion,
	@tarifa = i.tarifa,
	@tipo = a.tipo,
	@ocupantes = a.numeroOcupantes
	FROM inserted i
	inner join TipoHabitaciones a
	on i.idTipoHabitacion_FK = a.idTipoHabitacion

	INSERT INTO Suceso VALUES(GETDATE(), 'Habitaciones', 'Se ha Actualizado el registro con Id: ' + cast(@id as varchar)+ 
	', Numero habitacion: ' +@habitacion+ 
	', Tarifa: ' +cast(@tarifa as varchar)+
	', Tipo habitacion: ' +@tipo+
	' y Numero ocupantes: ' +cast(@ocupantes as varchar));
END
GO
 
--Trigger para Eliminar Habitacion
 
create TRIGGER tg_EliminarHabitacion
    ON Habitaciones
    AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @habitacion varchar(10), 
	@tarifa money, @tipo varchar(50), @ocupantes int;

	SELECT @id = i.idHabitacion,
	@habitacion = i.numeroHabitacion,
	@tarifa = i.tarifa,
	@tipo = a.tipo,
	@ocupantes = a.numeroOcupantes
	FROM deleted i
	inner join TipoHabitaciones a
	on i.idTipoHabitacion_FK = a.idTipoHabitacion

	INSERT INTO Suceso VALUES(GETDATE(), 'Habitaciones', 'Se ha Eliminado el registro con Id: ' + cast(@id as varchar)+ 
	', Numero habitacion: ' +@habitacion+ 
	', Tarifa: ' +cast(@tarifa as varchar)+
	', Tipo habitacion: ' +@tipo+
	' y Numero ocupantes: ' +cast(@ocupantes as varchar));
END